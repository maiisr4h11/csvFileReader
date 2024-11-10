using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CSVFileReader.Models;


namespace CSVFileReader.Controllers
{

    public class CsvController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadCsv(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Content("File not selected");

            var csvData = new List<CsvData>();

            using (var reader = new StreamReader(file.OpenReadStream()))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<CsvData>();
                csvData.AddRange(records);
            }

            return View(csvData);
        }
    }


}
