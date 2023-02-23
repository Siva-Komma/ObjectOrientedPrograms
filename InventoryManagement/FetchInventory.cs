﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class FetchInventory
    {
        public InventoryDetail Read(string path)
        {
            using (StreamReader file= new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDetail>(json);
                }
                catch (Exception ex) 
                {
                    return null;
                }
            }
        }

    }
}
