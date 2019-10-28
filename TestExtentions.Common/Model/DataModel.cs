using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentExcel;
using NPOI.Extension;
namespace TestExtentions.Common.Model
{
    public class DataModel :IDataModel
    {
        [Display(Name = "TestCaseName")]
        public String TestCaseName { get; set; }


        //[Column(Index = 2, Title = "Actual Result")]
        [Display(Name = "Actual Result")]
        public String ActualResult { get; set; }


        //[Column(Index = 1, Title = "Expected Result")]
        [Display(Name = "Expected Result")]
        public String ExpectedResult { get; set; }

        //[Column(Index = 3, Title = "Status")]
        [Display(Name = "Status")]
        public String Status { get; set; }
    }
}
