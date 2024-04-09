using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializar_y_Deserializar_XML_JSON
{
    public interface IFileRepository
    {
        void OpenCreateFile();
        void OpenFile();
        void WriteRecordToFile();
        string? ReadNextRecord();
        void ResetFilePointer();
        void CloseFile();

    }
}
