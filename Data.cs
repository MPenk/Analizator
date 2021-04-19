using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Analizator
{
    public class Data
    {
        string fileContent = string.Empty;
        string filePath = string.Empty;
        double[] tabOfData;
        int NumberOfLines = 0;
        double? average = null;
        double? variance = null;
        double? min = null;
        double? max = null;
        bool? fileIsOpen = null;


        /// <summary>
        /// Open and convert file.
        /// </summary>
        public Data() {
            this.fileIsOpen = this.OpenFile();
            if (this.fileIsOpen == true)
            {
               // MessageBox.Show("Otwarcie pliku zakończone sukcesem", "Otwarto plik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.NumberOfLines = this.LineCounter();
                if (this.NumberOfLines > 0)
                {
                    tabOfData = new double[this.NumberOfLines];
                    this.ConversionContent();
                }
            }
        }







        /// <summary>
        /// Conversion data from fileContent(string) to tabOfData(double[]).
        /// </summary>
        private void ConversionContent() {
            string tmpResult = "";
            int tmpLine = 0;
            bool? onlyOneMinus = null;
            foreach (var item in this.fileContent)
            {
                //Jeśli to liczba to dodaje ją do zmiennej tymczasowej
                if (item > 47 && item < 58) tmpResult += item.ToString();
                //Jeśli to przecinek lub kropka to dodaje przecinek do zmiennej tymczasowej;
                if (item == 44 || item == 46) tmpResult += ",";
                if (item == 45) {
                    if (onlyOneMinus == null)
                    {
                        onlyOneMinus = true;
                        tmpResult += "-";
                    }
                    else if (onlyOneMinus == true) {
                        onlyOneMinus = false;
                    }
                }

                //jeśli to średnik to zapisuje zmienną do tablicy
                if (item == '\n') tmpResult = "";
                if (item == 59 ) 
                {
                    if (tmpResult == "") continue;
                    if (tmpResult!=",") double.TryParse(tmpResult, out this.tabOfData[tmpLine]);
                    tmpResult = "";
                    tmpLine++;
                }
            }
        
        }
        public double[] GetFileContent()
        {
            return this.tabOfData;
        }

        public string GetFileName() {
            string name = "";
            for (int i = this.filePath.Length-1; i > 0; i--)
            {
                if (this.filePath[i] == '\\') return name;
                name =  this.filePath[i] + name;
            }
            return name;
        }
        public int GetDataLenght() {
            return this.NumberOfLines;
        }
        /// <summary>
        /// Calculating how many lines are in the data
        /// </summary>
        private int LineCounter() {
            int sumOfLines = 0;
            bool digitExist = false;
            foreach (var item in this.fileContent)
            {
                //sprawdzenie czy to koniec liczby
                if (item == ';' && digitExist == true)
                {
                    digitExist = false;
                    sumOfLines++;
                    continue;
                }
                //sprawdzenie czy w "liczbie nie znajdują się inne niepotrzebne znaki
                if ((item < 48 || item > 57) && (item != 44 || item != 46)) continue;

                //zaznaczenie że liczba posiada jakąkolwiek cyfrę
                if (item != 44 || item != 46) digitExist = true;
                
            }
            
            return sumOfLines;
        }
        /// <summary>
        /// Checking if data exists. Exist - true, no exist - false, file did not open - null
        /// </summary>
        public bool? Exist() {

            if(this.fileContent!=string.Empty && this.NumberOfLines>0) return true;
            if (this.fileIsOpen == null) return null;
            return false;
        }
        /// <summary>
        /// Min from tabOfData[].
        /// </summary>
        public double Min() {
            if (this.min != null) return Convert.ToDouble(this.min);
            this.min = this.tabOfData[0];
            for (int i = 1; i < this.NumberOfLines; i++)
            {
                if (this.min > this.tabOfData[i]) this.min = this.tabOfData[i];
            }

            return Convert.ToDouble(this.min);
        }
        /// <summary>
        /// Max from tabOfData[].
        /// </summary>
        public double Max()
        {
            if (this.max != null) return Convert.ToDouble(this.max);
            this.max = this.tabOfData[0];
            for (int i = 1; i < this.NumberOfLines; i++)
            {
                if (this.max < this.tabOfData[i]) this.max = this.tabOfData[i];
            }

            return Convert.ToDouble(this.max);
        }
        /// <summary>
        /// Variance from tabOfData[].
        /// </summary>
        public double Variance() {
            if (this.variance != null) return Convert.ToDouble(this.variance);
            this.variance = 0;
            foreach (var item in this.tabOfData)
            {
                this.variance += (item - this.Average()) * (item - this.Average());
            }
            this.variance /= this.NumberOfLines;
            return Convert.ToDouble(this.variance);
        }

        /// <summary>
        /// Average from tabOfData[].
        /// </summary>
        public double Average() {
            if (this.average != null) return Convert.ToDouble(this.average);
            this.average = 0;
            for (int i = 0; i < this.NumberOfLines; i++)
            {
                this.average += tabOfData[i];
            }
            this.average /= this.NumberOfLines;
            return Convert.ToDouble(this.average);
        }

        /// <summary>
        /// Open .txt file. success - true, error - false, cancel - null.
        /// </summary>
        private bool? OpenFile() {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                try
                {
                    openFileDialog.InitialDirectory = "C:\\";
                    openFileDialog.Filter = "Pliki txt (*.txt) | *.txt";
                    
                    if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName != "")
                    {
                        // Zapisywanie ścieżki pliku
                        this.filePath = openFileDialog.FileName;

                        // Wczytywanie pliku do Stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            try
                            {
                                this.fileContent = reader.ReadToEnd();
                            }
                            catch
                            {
                                MessageBox.Show("Niewłaściwe dane w pliku", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return false;
                            }
                            fileStream.Close();
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                catch {
                   // MessageBox.Show("Błąd podczas otwierania pliku", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Save results to .txt file, with choice of what save.
        /// </summary>
        public bool SaveFile(bool saveAverage = true, bool saveVariance = true, bool saveMin = true, bool saveMax = true)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                try
                {
                    saveFileDialog.InitialDirectory = this.filePath;
                    saveFileDialog.Filter = "Plik txt (*.txt) | *.txt";
                    saveFileDialog.Title = "Zapisz plik";
                    saveFileDialog.ShowDialog();
                    if (saveFileDialog.FileName != "")
                    {
                        var fileStream = saveFileDialog.OpenFile();
                        using (StreamWriter writer = new StreamWriter(fileStream))
                        {

                            if (saveAverage) writer.WriteLine("Średnia wartość wynosi: {0}", this.average);
                            if (saveVariance) writer.WriteLine("Warjancja wynosi: {0}", this.variance);
                            if (saveMin) writer.WriteLine("Wartość minimalna wynosi: {0}", this.min);
                            if (saveMax) writer.WriteLine("Wartosc maksymalna wynosi: {0}", this.max);
                        }
                        fileStream.Close();
                        return true;
                    }
                }
                catch
                {
                    MessageBox.Show("Błąd zapisu pliku","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }
                

            }
            return true;
        }
    }
}
