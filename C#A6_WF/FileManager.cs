using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace C_A6_WF
{
    /// <summary>
    /// Class holds file managing operations.
    /// </summary>
    internal class FileManager
    {
        /// <summary>
        /// Tries to read a file from the selected path.
        /// </summary>
        /// <param name="selectedFilePath">The path to read from</param>
        /// <returns>The contents of the file as a string</returns>
        internal string TryReadFile(string selectedFilePath)
        {
            string serializedFileContent;
            string? errorMessage;
            StreamReader streamReader = null!;
            
            try
            {
                streamReader = new StreamReader(selectedFilePath);
                
                serializedFileContent = streamReader.ReadToEnd();
            }
            catch (FileNotFoundException)
            {
                errorMessage = "File not found";
                return errorMessage;
            }
            catch (Exception)
            {
                errorMessage = "Something went wrong";
                return errorMessage;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }

            return serializedFileContent;
        }

        /// <summary>
        /// Tries to save to a file.
        /// </summary>
        /// <param name="tasksToSave">The tasks to be saved as a string</param>
        /// <param name="filePathSave">The file path to save to</param>
        internal string TrySaveFile(string tasksToSave, string filePathSave)
        {
            string message;
            StreamWriter streamWriter = null!;

            try
            {
                streamWriter = new StreamWriter(filePathSave);
                
                streamWriter.Write(tasksToSave);

                message = "Successful save";
            } 
            catch (FileNotFoundException)
            {
                message = "File not found";
                return message;
            }
            catch (Exception)
            {
                message = "Something went wrong";
                return message;
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }

            return message;
        }
    }
}
