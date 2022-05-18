using System;
using System.Collections.Generic;
using System.Text;

namespace AS2122_4E_INF_QuadrelliFabio_GestioneArticoli
{
    class Articolo 
    {
        string codice;
        string descrzione;
        string unitadimisura;
        double prezzo;

        public Articolo(string codice, string descrzione, string unitadimisura, double prezzo)
            {
                this.codice = codice;
                this.descrzione = descrzione;
                this.unitadimisura = unitadimisura;
                this.prezzo = prezzo;
        }
    
    public string Codice { get { return codice; } };
    public string Descrizione { get { return descrizione; } }
    public string UnitaDiMisura { get { return unitadimisura; } }
    public double Prezzo { get { return prezzo; } }
    }
}