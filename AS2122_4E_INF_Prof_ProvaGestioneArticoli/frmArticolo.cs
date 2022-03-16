using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4E_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmArticolo : Form
    {
        DialogResult status = DialogResult.Cancel;

        string nome;

        public string Valore { get; }
        public string Commento { get; }

        // TODO: (5) aggiungere attributi privati dei dati inseriti nella frmArticoli
        // ...

        private string Codice { get; private set; }
        private string Descrizione { get; private set; }
        private string Unita_Misura { get; private set; }
        private string Prezzo { get; private set; }
        public DialogResult Status { get { return status; } }

        // TODO: (6) aggiungere property di sola lettura dei dati inseriti nella frmArticoli per l'utilizzo in frmMain
        // ...
        public frmArticolo()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // TODO: (7) passaggio all' attributo/property dei dati inseriti nella frmArticoli con controllo di valorizzazione del dato
            // ... descrizione, unitaMisura, prezzo

            if(txtDescrizione.text = "" && txtunitaMisura = "" && txtprezzo = "")
            {
                message.Box("Dati inesistenti, inserisci nuovi dati");
            }
            else
            {
                Descrizione = txtDescrizione.text;
                Unita_Misura = txtunitaMisura.text;
                Prezzo = txtprezzo.text;
            }

            status = DialogResult.OK;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            status = DialogResult.Cancel;
            Close();
        }
    }
}
