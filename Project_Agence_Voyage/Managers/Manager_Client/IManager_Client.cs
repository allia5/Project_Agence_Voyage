﻿using Project_Agence_Voyage.Models.Vol;

namespace Project_Agence_Voyage.Managers.Manager_Client
{
    public interface IManager_Client
    {
        public List<Vol> Select_Vol_Recherch( string id_ville_origin, string id_ville_dist, DateTime Date_Depart, DateTime Date_return);
    }
}
