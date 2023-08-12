using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TresEnRaya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool cambiarTurno = true;     
        
        int ganadosX = 0;
        int ganadosO = 0;


        public MainWindow()
        {
            InitializeComponent();

            turno.Text = "Jugador X";
        }        

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Button boton = (Button)sender;
            
            Image image = new Image();

            if (boton.Content != null)
            {
                MessageBox.Show("Debes pulsar en una casilla vacía.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Exclamation);
               
            }
            else
            {
                if (cambiarTurno)
                {                    
                    image.Source = new BitmapImage(new Uri("x.gif", UriKind.Relative));
                    boton.Content = image;
                    boton.Tag = "x";
                    Ganador();
                    turno.Text = "Jugador O";
                }
                else
                {                    
                    image.Source = new BitmapImage(new Uri("o.gif", UriKind.Relative));
                    boton.Content = image;
                    boton.Tag = "o";
                    Ganador();
                    turno.Text = "Jugador X";
                }                              

                cambiarTurno = !cambiarTurno;
            }            
        }

        private void NuevoJuego_Click(object sender, RoutedEventArgs e)
        {
            ReiniciarJuego();
        }

        private void Ganador()
        {
            if (btn1.Tag != null && btn2.Tag != null && btn3.Tag != null && btn1.Tag == btn2.Tag && btn2.Tag == btn3.Tag)
            {
                MensajeGanador();
                Resultado();
                ReiniciarJuego();
            }
            else if (btn4.Tag != null && btn5.Tag != null && btn6.Tag != null &&  btn4.Tag == btn5.Tag && btn5.Tag == btn6.Tag)
            {
                MensajeGanador();
                Resultado();
                ReiniciarJuego();
            }
            else if (btn7.Tag != null && btn8.Tag != null && btn9.Tag != null &&  btn7.Tag == btn8.Tag && btn8.Tag == btn9.Tag)
            {
                MensajeGanador();
                Resultado();
                ReiniciarJuego();
            }
            else if (btn1.Tag != null && btn4.Tag != null && btn7.Tag != null && btn1.Tag == btn4.Tag && btn4.Tag == btn7.Tag)
            {
                MensajeGanador();
                Resultado();
                ReiniciarJuego();
            }
            else if (btn2.Tag != null && btn5.Tag != null && btn8.Tag != null && btn2.Tag == btn5.Tag && btn5.Tag == btn8.Tag)
            {
                MensajeGanador();
                Resultado();
                ReiniciarJuego();
            }
            else if (btn3.Tag != null && btn6.Tag != null && btn9.Tag != null && btn3.Tag == btn6.Tag && btn6.Tag == btn9.Tag)
            {
                MensajeGanador();
                Resultado();
                ReiniciarJuego();
            }
            else if (btn1.Tag != null && btn5.Tag != null && btn9.Tag != null && btn1.Tag == btn5.Tag && btn5.Tag == btn9.Tag)
            {
                MensajeGanador();
                Resultado();
                ReiniciarJuego();
            }
            else if (btn3.Tag != null && btn5.Tag != null && btn7.Tag != null && btn3.Tag == btn5.Tag && btn5.Tag == btn7.Tag)
            {
                MensajeGanador();
                Resultado();
                ReiniciarJuego();
            }
            else if (btn1.Tag != null && btn2.Tag != null && btn3.Tag != null && btn4.Tag != null && btn5.Tag != null && 
                btn6.Tag != null && btn7.Tag != null && btn8.Tag != null && btn9.Tag != null)
            {
                MessageBox.Show("Habéis empatado!!", "Empate!!", MessageBoxButton.OK, MessageBoxImage.Information);
                ReiniciarJuego();
            }
        }

        private void MensajeGanador()
        {
            MessageBox.Show("Ha ganado el " + turno.Text, "Ganador!!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ReiniciarJuego()
        {
            Button[] botonesArray = { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            for (int i = 0; i < 9; i++)
            {
                botonesArray[i].Content = null;
                botonesArray[i].Tag = null;
            }
        }

        private void Resultado()
        {  
            if (turno.Text == "Jugador X")
            {
                ganadosX++;
                resultadoX.Text = Convert.ToString(ganadosX);
            }
            else
            {
                ganadosO++;
                resultadoO.Text = Convert.ToString(ganadosO);
            }
        }

        private void RestablecerResultados_Click(object sender, RoutedEventArgs e)
        {
            ReiniciarJuego();
            ganadosX = 0;
            ganadosO = 0;
            resultadoX.Text = Convert.ToString(ganadosX);
            resultadoO.Text = Convert.ToString(ganadosO);
        }

        private void Creditos(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Tres en raya.\n\nCreado con WPF en Visual Studio.\n\nv1.0    20/07/2023\n\nFran Díaz", "Acerca de", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }   
}
