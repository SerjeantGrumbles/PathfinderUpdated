using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pathfinder.Properties;

namespace Pathfinder.Forms
{
    public partial class CharacterPortrait : Form
    {
        CreateCharacter createChar;
        CharacterSheet cSheet;
        public CharacterPortrait()
        {
            InitializeComponent();
        }

        private void CharacterPortrait_Load(object sender, EventArgs e)
        {
            // ensures that the createChar object is correctly cast as the starting form
            int i = 0;
            while (createChar == null)
            {
                if (Application.OpenForms[i] is CreateCharacter)
                {
                    createChar = (CreateCharacter)Application.OpenForms[i];
                }
                else
                {
                    i++;
                }
            }
        }

        private void lstSelectPortrait_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSelectPortrait.SelectedIndex != -1)
            {
                btnCreate.Enabled = true;
            }
            picPortrait.Image = (Image)Resources.ResourceManager.GetObject(lstSelectPortrait.Text);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            cSheet = new CharacterSheet();
            cSheet.playerCharacter = createChar.newCharacter;
            cSheet.playerCharacter.Portrait = picPortrait.Image;
            cSheet.Show();
            this.Hide();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            createChar.Show();
        }
    }
}
