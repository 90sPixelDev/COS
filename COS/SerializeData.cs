using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace COS
{
    class SerializeData
    {
        Stream stream = null;
        BinaryFormatter bf = null;

        public string fileName = "New Character Sheet";
        public string fullPath = "Gotta Add Path!";

        public SerializeData (string _fileName)
        {
            fileName = _fileName;
        }

        //public void SerializeObject(CharacterSheet charaSheetInfo)
        //{
        //    bf.Serialize(stream, charaSheetInfo);
        //}

        public void SerializeCharacterSheet(CharacterSheet charaSheet, string fileName)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(outFile, charaSheet);

                outFile.Close();
            }
        }

        public void DeserializeCharacterSheet(CharacterSheet charaSheet)
        {
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream loadFile = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                charaSheet = (CharacterSheet)bf.Deserialize(loadFile);

                loadFile.Close();
            }

            Debug.WriteLine(charaSheet.CharacterIndex.Count());
        }

        public static Object BinaryCharacterSheet(string fileName)
        {
            using (FileStream loadFile = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                object cs;
                try
                {
                    cs = binaryFormatter.Deserialize(loadFile);
                }
                catch (SerializationException ex)
                {
                    throw new SerializationException(((object)ex).ToString() + "\n" + ex.Source);
                }
                return cs;
            }
        }

        //public void DeserializeObjects()
        //{
        //    Object charaSheetInfo = null;
        //    stream = File.Open(txtFileName, FileMode.Open);
        //    try
        //    {
        //        while (stream.CanSeek)
        //        {
        //            charaSheetInfo = (Object)bf.Deserialize(stream);

        //            if(charaSheetInfo is CharacterSheet)
        //            {
        //                CharacterSheet cs = (CharacterSheet)charaSheetInfo;
        //                //Console.WriteLine(cs.PrintContent());
        //            }
        //            //else if ( Another type of Class/Data Class)
        //            //{
        //            //
        //            //}
        //        }
        //    }
        //    catch (SerializationException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine("End of File");
        //    }
        //}

        //public void CloseStream()
        //{
        //    stream.Close();
        //}
    }
}
