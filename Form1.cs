namespace WinFormsApp1
{
    public partial class TalkingBenRemake : Form
    {
        public TalkingBenRemake()
        {
            InitializeComponent();

            fBarParts = new PictureBox[] { pbFBar1, pbFBar2, pbFBar3, pbFBar4, pbFBar5, pbFBar6, pbFBar7, pbFBar8, pbFBar9, pbFBar10 };
            dBarParts = new PictureBox[] { pbDBar1, pbDBar2, pbDBar3, pbDBar4, pbDBar5, pbDBar6, pbDBar7, pbDBar8, pbDBar9, pbDBar10 };
        }


        string itemName;
        string itemTag;
        int fBarStav, dBarStav;
        PictureBox[] fBarParts;
        PictureBox[] dBarParts;

        private void ItemClick(object sender, EventArgs e)
        {
            Control clickedItem = sender as Control;

            itemName = clickedItem.Name;
            itemTag = clickedItem.Tag.ToString();

            tmrFood.Enabled = true;

        }


        private void tmrFood_Tick(object sender, EventArgs e)
        {
            switch (itemName)
            {
                case "pbArizona":
                    Point tempPoint = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
                    pbArizona.Location = this.PointToClient(tempPoint);
                    break;
                case "pbCupcake":
                    tempPoint = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
                    pbCupcake.Location = this.PointToClient(tempPoint);
                    break;
                case "pbHamburger":
                    tempPoint = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
                    pbHamburger.Location = this.PointToClient(tempPoint);
                    break;
                case "pbHotdog":
                    tempPoint = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
                    pbHotdog.Location = this.PointToClient(tempPoint);
                    break;
                case "pbIcetea":
                    tempPoint = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
                    pbIcetea.Location = this.PointToClient(tempPoint);
                    break;
                case "pbPizza":
                    tempPoint = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
                    pbPizza.Location = this.PointToClient(tempPoint);
                    break;
                case "pbSteak":
                    tempPoint = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
                    pbSteak.Location = this.PointToClient(tempPoint);
                    break;
            }
        }

        private void pbBen_MouseHover(object sender, EventArgs e)
        {
            if (fBarStav == 10)
            {
                tmrFood.Enabled = false;
                pbArizona.Location = new(66, 273);
                pbCupcake.Location = new(103, 273);
                pbHamburger.Location = new(140, 273);
                pbHotdog.Location = new(177, 273);
                pbIcetea.Location = new(214, 273);
                pbPizza.Location = new(250, 273);
                pbSteak.Location = new(66, 329);
                
            }
            else if (tmrFood.Enabled == true)
            {
                tmrFood.Enabled =false;
                pbArizona.Location = new(66,273);
                pbCupcake.Location = new(103, 273);
                pbHamburger.Location = new(140, 273);
                pbHotdog.Location = new(177, 273);
                pbIcetea.Location = new(214, 273);
                pbPizza.Location = new(250, 273);
                pbSteak.Location = new(66, 329);     
            }

            switch (itemTag)
            {
                case "food": 
                    fBarStav++;
                    fBarParts[fBarStav - 1].Visible = true;
                    break;

                case "drink":
                    dBarStav++;
                    dBarParts[dBarStav - 1].Visible = true;
                    break;


            }


        }

        
    }
}