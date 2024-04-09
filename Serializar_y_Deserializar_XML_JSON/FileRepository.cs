using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializar_y_Deserializar_XML_JSON
{
    public class FileRepository : IFileRepository
    {

        private StreamWriter? _filewriter;
        private StreamReader? _filereader;
        private FileStream? _filestream;
        private string _fileName;

        public FileRepository (string fileName)
        {
            _fileName = fileName;
        }
        public void CloseFile()
        {
            try
            {
                _filewriter?.Close();
                _filereader?.Close();
            }
            catch(IOException)
            {
                throw new IOException("No se puede cerrar el archivo");
            }

        }

        public void OpenCreateFile()
        {
            try
            {
                _filestream = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.Write);
                _filewriter = new StreamWriter(_filestream);
            }
            catch(IOException )
            {
                throw new IOException("Error al abrir el archivo");
            }

        }

        public void OpenFile()
        {
            try
            {
                _filestream = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
                _filereader = new StreamReader(_filestream);
            }
            catch(IOException )
            {
                throw new IOException("Error al abrir el archivo");
            }
        }

        public string? ReadNextRecord()
        {
            try
            {
                return _filereader?.ReadLine();
            }
            catch (IOException)
            {
                throw new IOException("Error al leer el archivo");
            }
        }

        public void ResetFilePointer()
        {
            try
            {
                _filestream?.Seek(0, SeekOrigin.Begin);
            }
            catch (IOException)
            {
                throw new IOException("Error al restablecer el puntero del archivo");
            }

        }

        public void WriteRecordToFile(Record record)
        {
            try
            {
                _filewriter?.WriteLine($"{record.Account},{record.FirstName},{record.LastName},{record.Balance}");
            }
            catch(IOException)
            {
                throw new IOException("Error al escribir en archivo");
            }
        }

        public void WriteRecordToFile()
        {
            throw new NotImplementedException();
        }
    }
}
