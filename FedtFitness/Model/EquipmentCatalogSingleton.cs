﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FedtFitness.Persistency;

namespace FedtFitness.Model
{
    class EquipmentCatalogSingleton
    {
        public ObservableCollection<Equipment> Equipments { get; set; }
        private static EquipmentCatalogSingleton _instance;

        private EquipmentCatalogSingleton()
        {
            Equipments = new ObservableCollection<Equipment>();
         // Equipments = new ObservableCollection<Equipment>(GenericFedtWebAPI<Equipment>.getAll("api/Equipments"));
            Equipments.Add(new Equipment(1, "Dumbells"));
            Equipments.Add(new Equipment(2,"None"));
            Equipments.Add(new Equipment(3, "Sandbox"));
        }

        public static EquipmentCatalogSingleton Instance
        {
            get
            {
                return _instance ?? (_instance = new EquipmentCatalogSingleton());
            }
        }
    }
}
