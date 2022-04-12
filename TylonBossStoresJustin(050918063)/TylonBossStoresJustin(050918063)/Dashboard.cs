using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace TylonBossStores
{
    public partial class Dashboard : Form1
    {
        static string storeDataFolder = "StoreData";

        class DisplayStore
        {
            public string storeName { get; set;}
            public string storeCode {get; set;}

        }
        List<double> StoreNameDp = new List<double>();
        List<double> theCosts = new List<double>();
        List<string> List2013 = new List<string>();
        List<string> storecodes = new List<string>();

        List<string> matchinstores = new List<string>();
        List<string> mostcomoni = new List<string>();

        Dictionary<string, double> plotChart = new Dictionary<string, double>();

        List<double> Cost2014 = new List<double>();
        List<double> CostMthLst = new List<double>();
        List<string> List2014 = new List<string>();

        List<DisplayStore> displays = new List<DisplayStore>();

        public string SupplierTyoo { get; set; }
        public string cbweek { get; set; }
        public string cbweek2 { get; set; }
        public string cbmonth { get; set; }
        public string cbmonth2 { get; set; }
        public string cbStore { get; set; }
        public string cbTstText { get; set; }
        public string cbStore2 { get; set; }
        public string cbYearWs { get; set; }
        public string cbYearMs { get; set; }
        public string cbYearTs { get; set; }
        public string cbYearci { get; set; }
        public string cbMonth { get; set; }
        public string SupplierName { get; set; }

        public string SupplierType { get; set; }

        public double Cost { get; set; }

        public double mCost { get; set; }

        public double CostY14 { get; set; }
        public double CostMth { get; set; }
        public double CostSY { get; set; }

        double TotalSumF, CostY;



        ArrayList List = new ArrayList();

         List<string> storeCodeList = new List<string>();
         List<string> storeNameList = new List<string>();

         List<string> productNameList = new List<string>();
         List<string> productTypeList = new List<string>();
         List<string> productPriceList = new List<string>();
        //
         List<string> WantFile = new List<string>();
         List<string> WantFile2 = new List<string>();
         List<string> All2014fList = new List<string>();

         List<string> firstWk13 = new List<string>();

        
        public Dashboard()
        {
            InitializeComponent();

           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;

            DialogResult dr = fbd.ShowDialog();

            if (dr.Equals(DialogResult.OK))
            {
               txtPath.Text = fbd.SelectedPath;
               Environment.SpecialFolder rootF = fbd.RootFolder;
               Console.WriteLine(txtPath.Text);
               foreach (string csvFile in Directory.EnumerateFiles(txtPath.Text, "*.csv").AsParallel())
                    
               {
                   List.Add(csvFile);
               }
               await Task.Run(() =>
               {
                   Parallel.Invoke(
                  () =>
                  {
                      Parallel.For(0, 52, i =>
                
                      this.cbW.Invoke(new MethodInvoker(() => this.cbW.Items.Add(i + 1))));
               
                  },

                  () =>
                  {
                      Parallel.ForEach(List.Cast<string>(), (fname) =>
                      {
                          string theFile = @fname;
                          string[] storeInfo = File.ReadAllLines(theFile);
                         
                          // foreach (String s in myArray.Cast<string>())
                          Parallel.ForEach(storeInfo, (s) =>
                          {
                              string[] orderSplit = s.Split(',');
                              this.cbTsi.Invoke(new MethodInvoker(() => this.cbTsi.Items.Add(orderSplit[0])));
                              this.cbTst.Invoke(new MethodInvoker(() => this.cbTst.Items.Add(orderSplit[0])));
                              this.cbWst.Invoke(new MethodInvoker(() => this.cbWst.Items.Add(orderSplit[0])));
                              this.cbMst.Invoke(new MethodInvoker(() => this.cbMst.Items.Add(orderSplit[0])));
                              //get all stores codes
                              storecodes.Add(orderSplit[0]);
                          });
                      });

                      //string[] fileNames = Directory.GetFiles(folderpath + @"\" + storeDataFolder);
                      string[] fileNames = Directory.GetFiles(txtPath.Text + @"\" + storeDataFolder);
                     
                          Parallel.ForEach(fileNames, (filePath) =>
                          {
                              //Get the Week and the  Year ABE1_1_2013
                              string fileNameExt = Path.GetFileName(filePath);
                               try
                                 {
                              string[] orderData = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + fileNameExt);
                                 }
                               catch (IOException) { MessageBox.Show("Another Program is accessing the file. Please close it and Retry.", "Oops!",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
                              //Add all the files the store folder to;
                              WantFile.Add(fileNameExt);

                          });
                      
                  }
              );

            });
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
        public void DisplaySortedFrequencies(Dictionary<string, int> frequencies)
            {

                storeN = "";
                storeX = 0 ;
                // Order pairs in dictionary from high to low frequency.
                var sorted = from pair in frequencies
                             orderby pair.Value descending
                             select pair;

                
                this.dgV.Invoke(new MethodInvoker(() =>
                            this.dgV.Visible = false
                            ));
                this.dgdV.Invoke(new MethodInvoker(() =>
                        this.dgdV.Visible = true
                        ));

                this.dgdV.Invoke(new MethodInvoker(() =>
                    this.dgdV.ColumnCount = 1
                    ));

                this.dgdV.Invoke(new MethodInvoker(() =>
                    this.dgdV.Columns[0].Name = "Top Sold Item"
                    ));
           
                foreach(var pair in sorted) 
                {

                    storeN = pair.Key;
                    storeX = pair.Value;

                    plotChart.Add(storeN, storeX);

                    this.dgdV.Invoke(new MethodInvoker(() => this.dgdV.Rows.Add(storeN)));
      
                };
       
            }
        public void DisplayTopsoldi(string Tsi) { 
        
        }
         static Dictionary<string, int> GetFrequencies(List<string> values)
            {
                var result = new Dictionary<string, int>();
                foreach (string value in values)
                {
                    if (value != null)
                    {
                        int count;
                        if (result.TryGetValue(value, out count))
                        {
                            // Increase existing value.
                            result[value] = count + 1;
                        }
                        else
                        {
                            // New value, set to 1.
                            result.Add(value, 1);
                        }
                    }
                }
                // Return the dictionary.
                return result;
            }
        private async void button1_Click(object sender, EventArgs e)
         {
            plotChart.Clear();
            matchinstores.Clear();
            cbStore = cbTsi.Text;
            cbYearci = cbTsiY.Text;
            
            if (txtPath.Text == "")
            {
                MessageBox.Show("Please Select The Correct Path");
            }
            else 
            {
                await Task.Run(() => { 
                Parallel.ForEach(WantFile, (eachF) =>
                {
                    Parallel.For(0, 52, wk =>
                    {
                        if (eachF != null)
                        {
                            if (eachF == cbStore + "_" + wk + "_" + cbYearci + ".csv")
                            {
                                string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + eachF);
                                Parallel.ForEach(orderData2, (orderInfo2) =>
                                {

                                    string[] orderSplit2 = orderInfo2.Split(',');

                                    matchinstores.Add(orderSplit2[0]);

                                });
                            }

                        }


                    });
                });
                    //Pass the lis of matching stores to my morting Methode
                var freqs = GetFrequencies(matchinstores);
                DisplaySortedFrequencies(freqs);
            
                });

                //The Chart
                 BarChart(); 
            }
            
            
        }
        //************************START******************************************************
        private async void btnWeekly_Click(object sender, EventArgs e)
        {
            txtWbT.Text = "";
            txtWTa.Text = "";
            txtWaT.Text = "";
            if (txtPath.Text == "")
            {
                MessageBox.Show("Please Select The Correct Path");
            }
            else
            {
                var startTime = DateTime.Now;
                // Initialize the variables that are going to hold the TOTALS
                TotalSumF = 0;
                List2013.Clear();
                List2014.Clear();
                theCosts.Clear();
                CostMthLst.Clear();
                CostSY = 0;
                CostY14 = 0;
               matchinstores.Clear();

                this.cbW.Invoke(new MethodInvoker(() => cbweek = this.cbW.Text));
                this.cbW.Invoke(new MethodInvoker(() => cbweek2 = this.cbW.Text));

                ////this.comboBox1.Invoke(new MethodInvoker(() => cbMonth = this.comboBox1.Text));
                this.cbWst.Invoke(new MethodInvoker(() => cbStore = this.cbWst.Text));
                this.cbWst.Invoke(new MethodInvoker(() => cbStore2 = this.cbWst.Text));
                this.cbYWs.Invoke(new MethodInvoker(() => cbYearWs = this.cbYWs.Text));




                await Task.Run(() =>
                    {

                        if (cbStore == "All Stores")
                        {
                            Console.WriteLine(" Hah Really! You Selected " + cbStore);
                            Parallel.ForEach(storecodes, (sc) =>{
                               // Console.WriteLine(sc);
                             Parallel.ForEach(WantFile, (group1) =>{
                                // group1_2013.Add(group1);
                                 if (group1 != null)
                                 {
                                     if (group1 == sc + "_" + cbweek + "_" + cbYearWs + ".csv")
                                     {
                                     matchinstores.Add(group1);
                                     Console.WriteLine(group1);
                                 string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + group1);
                                 Parallel.ForEach(orderData2, (orderInfo2) =>
                                 {

                                     string[] orderSplit2 = orderInfo2.Split(',');

                                     CostY14 = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  
                                    // Console.WriteLine(CostY14);
                                     TotalSumF += CostY14;
                                    
                                 });
                                 }
                                 }
                             });
                            });


                            double SaleTax = (TotalSumF * 2) / 100;
                            double Vat = (TotalSumF * 17) / 100;
                            double NHIL = (TotalSumF * 1) / 100;

                            double AmtAfterTax = TotalSumF -(SaleTax+Vat+NHIL);
                            double TaxAmnt = SaleTax + Vat + NHIL;

                            //Display Result To Ui Thread
                            this.txtWaT.Invoke(new MethodInvoker(() => this.txtWaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                            this.txtWTa.Invoke(new MethodInvoker(() => this.txtWTa.Text = String.Format("{0:C}",TaxAmnt).ToString()));
                            this.txtWbT.Invoke(new MethodInvoker(() => this.txtWbT.Text = String.Format("{0:C}", TotalSumF).ToString()));

                            //Check the amount of time consumed 
                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                        }
                        else
                        {


                            Task.Factory.StartNew(() =>
                            {
                                Console.WriteLine("Begin first task...");
                                // *******************If A Week and A Store is Selected get Store for 2013

                                Parallel.ForEach(WantFile, (f13) =>
                                {
                                    if (f13 == cbStore + "_" + cbweek + "_" + cbYearWs + ".csv")
                                    {
                                      
                                        matchinstores.Add(f13);

                                    }

                                });


                                // *********Get the cost 

                                Parallel.ForEach(matchinstores, (ms) =>
                                {
                                    string[] orderData1 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + ms);

                                    Parallel.ForEach(orderData1, (orderInfo1) =>
                                    {

                                        string[] orderSplit1 = orderInfo1.Split(',');

                                        CostSY = Convert.ToDouble(orderSplit1[2]); //  I have the Cost
                                        theCosts.Add(CostSY);
                                        //Console.WriteLine(CostSY);
                                    });
                                });

                            }).ContinueWith((prev) => {
                                Task.Run(() => {

                                    Console.WriteLine("Begin Factory 1 task...");
                                    Parallel.ForEach(theCosts, (cst) =>
                                    {
                                        TotalSumF += cst;

                                    });
                                    double SaleTax = (TotalSumF * 2) / 100;
                                    double Vat = (TotalSumF * 17) / 100;
                                    double NHIL = (TotalSumF * 1) / 100;

                                    double AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                    double TaxAmnt = SaleTax + Vat + NHIL;

                                    //Display Result To Ui Thread
                                    this.txtWaT.Invoke(new MethodInvoker(() => this.txtWaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                    this.txtWTa.Invoke(new MethodInvoker(() => this.txtWTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                    this.txtWbT.Invoke(new MethodInvoker(() => this.txtWbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                                });
                            
                            });  
  
                            //Check the amount of time consumed 
                            //Console.WriteLine(DateTime.Now - startTime);
                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));

                        }//end of the else of the if 

                    });
            }
        }

        private  void button5_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("Please Select The Correct Path");
            }
            else
            {
                this.dgV.Invoke(new MethodInvoker(() =>
                           this.dgV.Visible = true
                           ));
                this.dgdV.Invoke(new MethodInvoker(() =>
                        this.dgdV.Visible = false
                        ));

                Parallel.ForEach(List.Cast<string>(), (fname) =>
                {
                    string theFile = @fname;
                    string[] storeInfo = File.ReadAllLines(theFile);
                
                    Parallel.ForEach(storeInfo, (s) =>
                    {
                        string[] orderSplit = s.Split(',');
                        DisplayStore Ds = new DisplayStore
                        {
                            storeCode = orderSplit[0],
                            storeName = orderSplit[1],
                        };
                        displays.Add(Ds);
                    });
                });

                // Bind Sores to the DataGridView
                try
                {
                    var _bind2 = displays.Select(a => new
                    {

                        STORENAME = a.storeName,
                        STORECODE = a.storeCode

                    }).ToList();

                    dgV.DataSource = _bind2;
                   
                }catch{
                    MessageBox.Show("An error Ocured during the Data Binding");
                }
            }
        }

        private void dgV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnMonthly_Click(object sender, EventArgs e)
        {
            txtMaT.Text = "";
            txtMbT.Text = "";
            txtMTa.Text = "";

            if (txtPath.Text == "")
            {
                MessageBox.Show("Please Select The Correct Path");
            }
            else 
            {
                  double SaleTax = 0;
                  double Vat = 0;
                  double NHIL = 0;
                  double AmtAfterTax =0; 
                  double TaxAmnt =0;

                 var startTime = DateTime.Now;
                // Initialize the variables that are going to hold the TOTALS
                 TotalSumF = 0;
                 CostMthLst.Clear();
                 CostMth = 0;
                 firstWk13.Clear();
                 
                this.cbM.Invoke(new MethodInvoker(() => cbmonth = this.cbM.Text));
                this.cbM.Invoke(new MethodInvoker(() => cbmonth2 = this.cbM.Text));

                ////this.comboBox1.Invoke(new MethodInvoker(() => cbMonth = this.comboBox1.Text));
                 cbStore = cbMst.Text;
                 cbStore2 = cbMst.Text;
                cbYearMs = cbYMs.Text;




                await Task.Run(() =>
                    {
                        if (cbStore == "All Stores")
                        { 
                                Task.Factory.StartNew(() =>
                                { 
                                    if(cbmonth == "Month01")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_1_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_2_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_3_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_4_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                               
                                                }
                                            });
                                        });
                                    }
                                    else if (cbmonth == "Month02")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_5_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_6_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_7_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_8_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                                
                                                }
                                            });
                                        });
                                    }
                                    
                                    else if (cbmonth == "Month03")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_9_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_10_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_11_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_12_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                               
                                                }
                                            });
                                        });
                                    }
                                    else if (cbmonth == "Month04")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_13_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_14_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_15_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_16_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                                 
                                                }
                                            });
                                        });
                                    }
                                    else if (cbmonth == "Month05")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_17_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_18_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_19_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_20_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                                
                                                }
                                            });
                                        });
                                    }
                                    else if (cbmonth == "Month06")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_21_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_22_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_23_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_24_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                               
                                                }
                                            });
                                        });
                                    }
                                    else if (cbmonth == "Month07")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_25_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_26_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_27_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_28_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                                
                                                }
                                            });
                                        });
                                    }
                                    else if (cbmonth == "Month08")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_29_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_30_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_31_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_32_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                               
                                                }
                                            });
                                        });
                                    }
                                    else if (cbmonth == "Month09")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_33_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_34_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_35_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_36_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                                
                                                }
                                            });
                                        });
                                    }
                                    else if (cbmonth == "Month10")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_37_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_38_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_39_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_40_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                               
                                                }
                                            });
                                        });
                                    }

                                   else if (cbmonth == "Month11")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_41_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_42_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_43_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_44_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                                
                                                }
                                            });
                                        });
                                    }
                                    else if (cbmonth == "Month12")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_45_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_46_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_47_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_48_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                                  
                                                }
                                            });
                                        });
                                    }
                                    else if (cbmonth == "Month13")
                                    {
                                        Parallel.ForEach(storecodes, (sc) =>
                                        {
                                            Parallel.ForEach(WantFile, (fW13) =>
                                            {
                                                if (fW13 == sc + "_49_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_50_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_51_" + cbYearMs + ".csv"
                                            || fW13 == sc + "_52_" + cbYearMs + ".csv"
                                                    )
                                                {

                                                    firstWk13.Add(fW13);
                                                  
                                                }
                                            });
                                        });
                                    }
                                    else { MessageBox.Show("Please Select Month"); }
                                   
                                }).ContinueWith((prev) =>
                                {
                                    Parallel.ForEach(firstWk13, (md) =>
                                    {
                                        string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                        Parallel.ForEach(orderData2, (orderInfo2) =>
                                        {

                                            string[] orderSplit2 = orderInfo2.Split(',');

                                            CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                            //Add all the costs
                                            //Console.WriteLine(CostMth);
                                            TotalSumF += CostMth;
                                        });
                                    });
                                     SaleTax = (TotalSumF * 2) / 100;
                                     Vat = (TotalSumF * 17) / 100;
                                     NHIL = (TotalSumF * 1) / 100;

                                     AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                     TaxAmnt = SaleTax + Vat + NHIL;

                                    //Display Result To Ui Thread
                                    this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                    this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                    this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                                });

                                this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));

                           

                        }
                        else if (cbmonth == "Month01")
                        {//Month01-(Week1-Week4)
                            Task.Factory.StartNew(() => { 
                                    Parallel.ForEach(WantFile, (fW13) =>
                                    {
                                        if (fW13 == cbStore + "_1_"+cbYearMs+".csv"
                                    || fW13 == cbStore + "_2_" + cbYearMs + ".csv"
                                    || fW13 == cbStore + "_3_" + cbYearMs + ".csv"
                                    || fW13 == cbStore + "_4_" + cbYearMs + ".csv"
                                            )
                                        {
                                           
                                            firstWk13.Add(fW13);

                                        }
                                    });
                            }).ContinueWith((prev) => {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  
                                       
                                        //Add all the costs
                                        TotalSumF += CostMth;      
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                          //end of this 
                        }
                        else if (cbmonth == "Month02")
                        {//Month02-(Week5-Week8)
                            Console.WriteLine("Hey welcome to month02");
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_5_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_6_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_7_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_8" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month03")
                        {//Month03-(Week9-Week12)
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_9_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_10_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_11_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_12_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month04")
                        {//Month04-(Week13-Week16)
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_13_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_14_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_15_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_16_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month05")
                        {//Month05-(Week17-Week20)
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_17_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_18_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_19_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_20_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month06")
                        {// Month06-(Week21-Week24)
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_21_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_22_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_23_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_24_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month07")
                        {// Month07-(Week25-Week28)
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_25_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_26_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_27_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_28_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month08")
                        {//Month08-(Week29-Week32)
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_29_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_30_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_31_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_32_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month09")
                        {//Month09-(Week33-Week36)
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_33_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_34_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_35_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_36_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month10")
                        {//Month10-(Week37-Week40)
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_37_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_38_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_39_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_40_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month11")
                        {//Month11-(Week41-Week44)
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_41_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_42_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_43_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_44_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month12")
                        {// Month12-(Week45-Week48)
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_45_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_46_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_47_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_48_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else if (cbmonth == "Month13")
                        {//Month13-(Week49-Week52)
                            Console.WriteLine("Hey welcome to month13");
                            Task.Factory.StartNew(() =>
                            {
                                Parallel.ForEach(WantFile, (fW13) =>
                                {
                                    if (fW13 == cbStore + "_49_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_50_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_51_" + cbYearMs + ".csv"
                                || fW13 == cbStore + "_52_" + cbYearMs + ".csv"
                                        )
                                    {

                                        firstWk13.Add(fW13);

                                    }
                                });
                            }).ContinueWith((prev) =>
                            {
                                Parallel.ForEach(firstWk13, (md) =>
                                {
                                    string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + md);

                                    Parallel.ForEach(orderData2, (orderInfo2) =>
                                    {

                                        string[] orderSplit2 = orderInfo2.Split(',');

                                        CostMth = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  

                                        //Add all the costs
                                        TotalSumF += CostMth;
                                    });
                                });
                                SaleTax = (TotalSumF * 2) / 100;
                                Vat = (TotalSumF * 17) / 100;
                                NHIL = (TotalSumF * 1) / 100;

                                AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                                TaxAmnt = SaleTax + Vat + NHIL;

                                //Display Result To Ui Thread
                                this.txtMaT.Invoke(new MethodInvoker(() => this.txtMaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                                this.txtMTa.Invoke(new MethodInvoker(() => this.txtMTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                                this.txtMbT.Invoke(new MethodInvoker(() => this.txtMbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                            });

                            this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                            //end of this 
                        }
                        else
                        {
                            Console.WriteLine("Ooops Nothing Found");
                        }
                       
                    });
            }
            
           

        }

        private async void btnAll_Click(object sender, EventArgs e)
        {
            var startTime = DateTime.Now;
            TotalSumF = 0;
            CostY = 0;
            txtAsbT.Text = "";
            txtAsaT.Text = "";
            txtAsTa.Text = "";
            matchinstores.Clear();
            cbYearTs = cbYTs.Text;
            //this.cbTst.Invoke(new MethodInvoker(() => cbStore = this.cbTst.Text));
            cbStore = cbTst.Text;
            if (txtPath.Text == "")
            {
                MessageBox.Show("Please Select The Correct Path");
            }
            else 
            {
                double SaleTax = 0;
                double Vat = 0;
                double NHIL = 0;
                double AmtAfterTax = 0;
                double TaxAmnt = 0;
                await Task.Run(() => {

                if (cbStore == "All Stores")
                {
                    Console.WriteLine(" Hah Really! You Selected " + cbStore);
                    //All stores
                    Parallel.ForEach(WantFile, (eachF) =>
                    {
                        string[] orderSplit1 = eachF.Split('_');
                        if (orderSplit1[2] == cbYearTs + ".csv")
                        {
                            string[] orderData = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + eachF);
                            Parallel.ForEach(orderData, (orderInfo) =>
                            {

                                string[] orderSplit2 = orderInfo.Split(',');

                                CostY = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  
                                //Console.WriteLine(CostY);
                                TotalSumF += CostY;

                            });

                        }
       
                    });

                    //Display Result To Ui Thread
                    SaleTax = (TotalSumF * 2) / 100;
                    Vat = (TotalSumF * 17) / 100;
                    NHIL = (TotalSumF * 1) / 100;

                    AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                    TaxAmnt = SaleTax + Vat + NHIL;

                    //Display Result To Ui Thread
                    this.txtAsaT.Invoke(new MethodInvoker(() => this.txtAsaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                    this.txtAsTa.Invoke(new MethodInvoker(() => this.txtAsTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                    this.txtAsbT.Invoke(new MethodInvoker(() => this.txtAsbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                    Console.WriteLine(" Done " );
                    //Check the amount of time consumed 
                    this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
                }
                else { 
                // perform op for th store selected
                   
                
                    Parallel.ForEach(WantFile, (eachF) =>
                    {
                        Parallel.For(0, 52, wk =>
                        { 
                        //matchinstores.Add(eachF);

                        if (eachF != null)
                        {
                            if (eachF == cbStore + "_" + wk + "_" + cbYearTs + ".csv")
                            {
                                string[] orderData2 = File.ReadAllLines(txtPath.Text + @"\" + storeDataFolder + @"\" + eachF);
                                Parallel.ForEach(orderData2, (orderInfo2) =>
                                {

                                    string[] orderSplit2 = orderInfo2.Split(',');

                                    CostY = Convert.ToDouble(orderSplit2[2]); //  I have the Cost  
                                    //Console.WriteLine(CostY);
                                    TotalSumF += CostY;

                                });
                            }
                           
                        }


                    });
                    });

                    SaleTax = (TotalSumF * 2) / 100;
                    Vat = (TotalSumF * 17) / 100;
                    NHIL = (TotalSumF * 1) / 100;

                    AmtAfterTax = TotalSumF - (SaleTax + Vat + NHIL);
                    TaxAmnt = SaleTax + Vat + NHIL;

                    //Display Result To Ui Thread
                    this.txtAsaT.Invoke(new MethodInvoker(() => this.txtAsaT.Text = String.Format("{0:C}", AmtAfterTax).ToString()));
                    this.txtAsTa.Invoke(new MethodInvoker(() => this.txtAsTa.Text = String.Format("{0:C}", TaxAmnt).ToString()));
                    this.txtAsbT.Invoke(new MethodInvoker(() => this.txtAsbT.Text = String.Format("{0:C}", TotalSumF).ToString()));
                    Console.WriteLine(" Done ");
                    //Check the amount of time consumed 
                    this.lblTimer.Invoke(new MethodInvoker(() => this.lblTimer.Text = Convert.ToString(DateTime.Now - startTime)));
              
                }

                });//end of await
                
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void  BarChart()
        {
            this.chartControl.Series.Clear();
          

            // Data arrays
           
           
                //this.chartControl.Palette = ChartColorPalette.EarthTones;
           
            // Set title
            //this.chartControl.Titles.Add("TylonBoss Stats");
           
            // Add series.

           // Series series = this.chartControl.Series.Add("Items");
            foreach (KeyValuePair<string, double> elmt in plotChart)
            {
                //Console.WriteLine("Key = {0}, Value = {1}",
                //                  elmt.Key, elmt.Value);

               string iname = Convert.ToString(elmt.Key);
               double inameX = Convert.ToDouble(elmt.Value);
             //  chartControl.Series["Items"].Points.AddXY(iname, inameX);

               Series series = this.chartControl.Series.Add(iname);
               series.Points.AddXY(iname, inameX);

               // Series series2 = this.chartControl.Series.Add(iname);
               // series2.Points.Add(inameX);
            } 
        }



        public static string storeN { get; set; }

        public static double storeX { get; set; }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgV.DataBindings.Clear();
        }
    }
}
