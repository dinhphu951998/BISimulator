using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BISimulator.Models;
using BISimulator.ViewModels;
using BISimulator.Utilities;
using BISimulator.Context;

namespace BISimulator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FusionController : ControllerBase
    {
        private readonly BISimulatorContext dbContext;

        public FusionController(BISimulatorContext context)
        {
            dbContext = context;
        }


        [HttpGet]
        public async Task<dynamic> GetRecords(RequestFusionViewModel fusionViewModel)
        {
            var fusionContext = CreateFusionContext(fusionViewModel);

            FusionUtility fusion = new FusionUtility(fusionContext);

            var tree = fusion.BuildTree(fusionContext);



            return null;
        }

        private FusionContext CreateFusionContext(RequestFusionViewModel fusionViewModel)
        {
            var connection = dbContext.Connection.Where(con => con.Value.Equals(fusionViewModel.ConnectionString, StringComparison.OrdinalIgnoreCase))
                                                 .FirstOrDefault();

            var table = dbContext.Table.Where(t => t.Name.Equals(fusionViewModel.Table, StringComparison.OrdinalIgnoreCase))
                                       .FirstOrDefault();

            var allFields = table?.Field.ToList();

            var expectedFields = new List<Field>();

            fusionViewModel.Fields.ForEach( f => 
            {
                allFields.ForEach(field =>
                {
                    if (field.Name.Equals(f.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        expectedFields.Add(field);
                    }
                });
            });

            return new FusionContext() { Connection = connection,Table = table,Fields = expectedFields };
        }

    }
}
