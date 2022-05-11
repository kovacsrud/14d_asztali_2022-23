using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfRandomUser
{
    /// <summary>
    /// Interaction logic for PrintView.xaml
    /// </summary>
    public partial class PrintView : Window
    {
        Users users;
        public PrintView(Users users)
        {
            InitializeComponent();
            this.users = users;
            CreateDoc();
        }

        private void CreateDoc()
        {
            Paragraph cim = new Paragraph(new Run("Felhasználók listája"));
            cim.TextAlignment = TextAlignment.Center;
            cim.Foreground = Brushes.Blue;
            flowUsers.Blocks.Add(cim);

            foreach (var i in users.results)
            {
                Paragraph nev = new Paragraph();
                nev.Inlines.Add(new Bold(new Run("Név:")));
                nev.Inlines.Add(new Run($"{i.name.title}.{i.name.first} {i.name.last}"));
                flowUsers.Blocks.Add(nev);
                Paragraph telefon = new Paragraph();
                telefon.Inlines.Add(new Bold(new Run("Telefonszámok:")));
                telefon.Inlines.Add(new Run($"{i.phone} {i.cell}"));
                flowUsers.Blocks.Add(telefon);
                Paragraph kep = new Paragraph();
                kep.Inlines.Add(new Bold(new Run("Kép:")));
                Image userkep = new Image();
                userkep.Source = new BitmapImage(new Uri(i.picture.large));
                userkep.Width = 300;
                kep.Inlines.Add(userkep);
                flowUsers.Blocks.Add(kep);

            }

            
        }

        private void buttonNyomtat_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            IDocumentPaginatorSource ps = flowUsers;
            flowUsers.PageWidth = printDialog.PrintableAreaWidth;
            flowUsers.PageHeight = printDialog.PrintableAreaHeight;
            flowUsers.ColumnWidth = printDialog.PrintableAreaWidth;
            if (printDialog.ShowDialog()==true)
            {
                printDialog.PrintDocument(ps.DocumentPaginator, "UserPrint");
            }
        }
    }
}
