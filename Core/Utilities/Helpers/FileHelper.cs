using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            var result = newPath(file);
            try
            {
                var sourcepath = Path.GetTempFileName();
                if (file.Length > 0)
                {
                    using (var stream = new FileStream(sourcepath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
                File.Move(sourcepath, result.newPath);

            }
            catch (Exception exception)
            {
                return exception.Message;
            }

            return result.path2;
        }

        public static IResult Delete(string path )
        {
            try
            {
               var deletePath = Environment.CurrentDirectory + @"\wwwroot" + path;

               File.Delete(deletePath);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }

        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            try
            {
                if (sourcePath.Length > 0)
                {
                    using (var stream = new FileStream(result.newPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
                //File.Move(sourcePath,);
                Delete(sourcePath);


            }
            catch (Exception)
            {

                throw;
            }

            return result.path2;

        }

        public static (string newPath, string path2) newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;

            var newName = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

            string path = Environment.CurrentDirectory + @"\wwwroot\Images";

            string result = $@"{path}\{newName}";

            return (result, $"\\Images\\{newName}");
        }
    }
}
