using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Threading.Tasks;

namespace 翻牌子
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Play p=new Play();
        string show1 = "";
        string show2 = "";
        int k = 0;
        Button f = new Button();
        int score = 0;
        public MainWindow()
        {
            InitializeComponent(); 
        }
        class Play { 
          public string[] Name={"孙笑川","丁真","王源","易烊千玺","马嘉祺","蔡徐坤","陈睿","东雪莲",
                "孙笑川","丁真","王源","易烊千玺","马嘉祺","蔡徐坤","陈睿","东雪莲"};
            public bool[] ButtonCanSee = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

            public void Chaos()
            {
                Random r = new Random();
                for (int i = 0; i < this.Name.Length; i++)
                {
                    int t=r.Next(0,this.Name.Length);
                    string temp=this.Name[i];
                    this.Name[i]=this.Name[t];
                    this.Name[t]=temp;
                }
            }
           
        
        
        }
        private void ReStart_Click(object sender, RoutedEventArgs e)
        {
           
            p.Chaos();
            k = 0;
            Key1.Content ="";
            Key2.Content = "";
            Key3.Content = "";
            Key4.Content = "";
            Key5.Content = "";
            Key6.Content = ""; 
            Key7.Content = "";
            Key8.Content = "";
            Key9.Content = "";
            Key10.Content = "";
            Key11.Content = "";
            Key12.Content = "";
            Key13.Content = "";
            Key14.Content = "";
            Key15.Content = "";
            Key16.Content = "";
            for (int i = 0; i < p.ButtonCanSee.Length; i++)
            {
                p.ButtonCanSee[i] = false;
            }
            
        }

        private async void Key1_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key1.Content = p.Name[0];
            if (k == 0)
            {
                show1 = p.Name[0];
                k += 1;
                f = Key1;
            }
            else
            {
                show2 = p.Name[0];
                k = 0;
                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key1.Content = null;
                    f.Content = null;
                }
            }
           
           
        }

        private async void Key2_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key2.Content = p.Name[1];
            if (k == 0)
            {
                show1 = p.Name[1];
                k += 1;
                f = Key2;
            }
            else
            {
                show2 = p.Name[1];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key2.Content = null;
                    f.Content= null;
                }
            }
           
        }

        private async void Key3_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key3.Content = p.Name[2];
            if (k == 0)
            {
                show1 = p.Name[2];
                k += 1;
                f = Key3;
            }
            else
            {
                show2 = p.Name[2];
                k = 0;
                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key3.Content = null;
                    f.Content=null;
                }
            }
           
        }

        private async void Key4_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key4.Content = p.Name[3];
            if (k == 0)
            {
                show1 = p.Name[3];
                k += 1;
                f = Key4;
            }
            else
            {
                show2 = p.Name[3];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key4.Content = null;
                    f.Content=null;
                }
            }
          
        }

        private async void Key5_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key5.Content = p.Name[4];
            if (k == 0)
            {
                show1 = p.Name[4];
                k += 1;
                f = Key5;
            }
            else
            {
                show2 = p.Name[4];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key5.Content = null;
                    f.Content=null;
                }
            }
          
        }

        private async void Key6_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key6.Content = p.Name[5];
            if (k == 0)
            {
                show1 = p.Name[5];
                k += 1;
                f = Key6;
            }
            else
            {
                show2 = p.Name[5];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key6.Content = null;
                    f.Content=null;
                }
            }
        }

        private async void Key7_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key7.Content = p.Name[6];
            if (k == 0)
            {
                show1 = p.Name[6];
                k += 1;
                f = Key7;
            }
            else
            {
                show2 = p.Name[6];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay (1000);
                    Key7.Content = null;
                    f.Content=null;
                }
            }
           
        }

        private async void Key8_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key8.Content = p.Name[7];
            if (k == 0)
            {
                show1 = p.Name[7];
                k += 1;
                f = Key8;
            }
            else
            {
                show2 = p.Name[7];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key8.Content = null;
                    f.Content=null;
                }
            }
            
        }

        private async void Key9_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key9.Content = p.Name[8];
            if (k == 0)
            {
                show1 = p.Name[8];
                k += 1;
                f = Key9;
            }
            else
            {
                show2 = p.Name[8];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key9.Content = null;
                    f.Content=null;
                }
            }
           
        }

        private async void Key10_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key10.Content = p.Name[9];
            if (k == 0)
            {
                show1 = p.Name[9];
                k += 1;
                f = Key10;
            }
            else
            {
                show2 = p.Name[9];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key10.Content = null;
                    f.Content=null;
                }
            }
            
        }

        private async void Key11_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key11.Content = p.Name[10];
            if (k == 0)
            {
                show1 = p.Name[10];
                k += 1;
                f = Key11;
            }
            else
            {
                show2 = p.Name[10];
                k = 0;
                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key11.Content = null;
                    f.Content = null;
                }
            }
        }

        private async void Key12_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key12.Content = p.Name[11];
            if (k == 0)
            {
                show1 = p.Name[11];
                k += 1;
                f = Key12;
            }
            else
            {
                show2 = p.Name[11];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key12.Content = null;
                    f.Content = null;
                }
            }
            
        }

        private async void Key13_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key13.Content = p.Name[12];
            if (k == 0)
            {
                show1 = p.Name[12];
                k += 1;
                f = Key13;
            }
            else
            {
                show2 = p.Name[12];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key13.Content = null;
                    f.Content = null;
                }
            }
           
        }

        private async void Key14_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key14.Content = p.Name[13];
            if (k == 0)
            {
                show1 = p.Name[13];
                k += 1;
                f = Key14;
            }
            else
            {
                show2 = p.Name[13];
                k = 0;
             
                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key14.Content = null;
                    f.Content = null;
                }
            }
          
        }

        private async void Key15_Click(object sender, RoutedEventArgs e)
        {
            score += 1;
            Key15.Content = p.Name[14];
            if (k == 0)
            {
                show1 = p.Name[14];
                k += 1;
                f = Key15;
            }
            else
            {
                show2 = p.Name[14];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key15.Content = null;
                    f.Content = null;
                }
            }
           
        }

        private async void Key16_Click(object sender, RoutedEventArgs e)
        {
            score += 1; 
            Key16.Content = p.Name[15];
            if (k == 0)
            {
                show1 = p.Name[15];
                k += 1;
                f = Key16;
            }
            else
            {
                show2 = p.Name[15];
                k = 0;

                if (show1 != show2)
                {
                    await Task.Delay(1000);
                    Key16.Content = null;
                    f.Content = null;
                }
            }
          
        }

      
    }
}