using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            AllTableEntity<Obj>().Where(x => x.RowKey == "1");


            AllTableEntity<Obj>().Where(x => x.PartitionKey == "1");
        }



        public static IQueryable<T> AllTableEntity<T>() where T : ITableEntity, new()
        {
            return null;
        }
    }

    public class Obj : TableEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
    }
}
