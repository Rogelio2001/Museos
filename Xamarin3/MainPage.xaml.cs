using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Xamarin3.DataModel;
/*Alumnos: Rogelio Zuñiga Estrada               010127169
           Francisco Raul Alvarado Romero       010113251
           Daniel Ayala Domínguez               010125921
 */

namespace Xamarin3
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Museos> grupo;
        public MainPage()
        {
            InitializeComponent();

            grupo = new ObservableCollection<Museos>
            {
                new Museos { Nombre = "Museo Nacional de Antropología", Foto = "Antropologia.jpg", Tipo = "Historia", 
                    Descripcion="Para los curiosos y amantes de la cultura maya y azteca" },

                new Museos { Nombre = "Palacio de Bellas Artes", Foto = "BellasArtes.jpg", Tipo = "Arte", 
                    Descripcion="Ya sea para ver una bailable o simplemente para ver su exposición de pinturas y murales es lo mejor" },
                
                new Museos { Nombre = "Frida Kahlo", Foto = "FridaKhalo.jpg", Tipo = "Especializados", 
                    Descripcion="La Casa Azul es el Universo Íntimo de Frida Kahlo. " +
                    "En esta bella residencia, vivió la artista la mayor parte de su vida" },
                
                new Museos { Nombre = "Soumaya", Foto = "Soumaya.jpg", Tipo = "Especializados",
                    Descripcion="Exhibe más de seis mil piezas de arte de la Fundación Carlos Slim, que atesora más de 60 mil obras artísticas, " +
                    "entre ellas la mayor colección de piezas de Rodin fuera de Francia."},
                
                new Museos { Nombre = "Templo Mayor", Foto = "TemploMayor.jpg", Tipo = "Historia",
                    Descripcion="Es un recinto que comprende una serie de construcciones, edificios, torres y un patio" },
                
                new Museos { Nombre = "Memoria_y_Tolerancia", Foto = "MemoriayTolerancia.jpg", Tipo = "Historia",
                    Descripcion="Difundir la importancia de la tolerancia, la no violencia, la memoria y los Derechos Humanos."},
                
                new Museos { Nombre = "Arte Popular", Foto = "ArtePopular.jpg", Tipo = "Arte",
                    Descripcion="El inmueble, que data de 1928, es el segundo más importante del estilo art decó en México. }" +
                    "Fue dado en comodato en 1996 por el Gobierno del Distrito Federal."},
                
                new Museos { Nombre = "Nacional de Arte", Foto = "NacionaldeArte.jpg", Tipo = "Especializados",
                    Descripcion="Fungía como Palacio de Comunicaciones y Obras Públicas, " +
                    "está situado en el corazón del Centro Histórico de la Ciudad de México" }



            };
            lvgrupo.ItemsSource = grupo;


        }
        private void lsvGrupo_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Museos p = (Museos)e.Item;
            lbdescrip.Text = p.Descripcion;
            //((ListView) sender).SelectedItem = null;
        }

        /* Este evento se dispara cuando se ha seleccionado un NUEVO elemento
         * Si un elemento ya ha sido seleccionado, este evento ya no se dispara */
        private void lsvGrupo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Museos p = (Museos)e.SelectedItem;
            
        }

    }
}
