/*
CMPSC 472 Spring 2023
Lab: Windows App, File System
Besjana Kubick
Edited: 03/31/2023

This program creates a Windows app using C# and Windows Presentation Form to simulate a file system
The program shows sectors taken up by the file depending on the filesize. 
After filling the file name and size the add button is activated,
and the file is added in the sectors list as well as the file system list. 
The sectors list displays in which sectors files are saved.
Through the file system list we can remove files.
There are in total 20 sector that can be used and the maximum size of a sector is 500
If a file is larger than 500 then it will be split in more than one sector

Last Edited: 04/30/2023

Improvements: 
- The counter label keeps track of the files added or removed in the lstFileSystem
- Each file added in the lstSector will now show the previous and the next sector it is connected to
-- (-1) represents the first/last sector of a file
- Fixed the error message box to work properly when all sectors are full.

Problems:
- Sector 5 is never occupied. When adding a file and sector 5 is the next available sector,
    the file will skip that sector.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ganther_FCG
{
    public partial class winMain : Form
    {
        //declare variables
        private const int MAX_SECTOR_SIZE = 500;
        private const int MAX_Sectors = 20;
        private Dictionary<string, List<int>> fileToSectors = new Dictionary<string, List<int>>();

        public winMain()
        {
            InitializeComponent();

            //Autosize for the File System list
            Panel panel = new Panel();
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            // Add the ListBox to the Panel
            panel.Controls.Add(lstFileSystem);

            // Add the Panel to the parent control 
            this.Controls.Add(panel);

            for (int i = 0; i < MAX_Sectors; i++)
            {
                lstFileSystem.Items.Add("");
                lstSectors.Items.Add("");
            }
            //start the window with add and remove button deactivated
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;

        }

        //Increment file counter
        private void IncrementFileCount()
        {
            int currentCount = int.Parse(lblFileCount.Text);
            currentCount++;
            lblFileCount.Text = currentCount.ToString();
        }

        //Decrement file counter
        private void DecrementFileCount()
        {
            int currentCount = int.Parse(lblFileCount.Text);
            currentCount--;
            lblFileCount.Text = currentCount.ToString();

        }

        /*
         When user clicks on the REMOVE button
            a. -User must selected a file from the File System list.
            b. -If one is selected, the Remove button will be Enabled.
            c. -When Remove is clicked, remove the item from the File System List, and the
            sectors entries, from the List of Sectors.
        */
        private void btnRemove_Click(object sender, EventArgs e)
        {

            string selectedFile = lstFileSystem.SelectedItem.ToString();

            if (fileToSectors.ContainsKey(selectedFile))
            {
                foreach (int sectorIndex in fileToSectors[selectedFile])
                {
                    lstSectors.Items[sectorIndex] = "";
                }
                fileToSectors.Remove(selectedFile);
            }

            lstFileSystem.Items.Remove(selectedFile);
            DecrementFileCount();

        }

        // Remove file selected in the fily system list from the sectors list
        private void RemoveFileFromSectors(string fileInfo)
        {
            for (int i = 0; i < lstSectors.Items.Count; i++)
            {
                if (lstSectors.Items[i].ToString().Contains(fileInfo))
                {
                    lstSectors.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        // Functions to enable the Add Button when user inputs both file name and size
        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            CheckAddEnable();
        }
        private void txtFileSize_TextChanged(object sender, EventArgs e)
        {
            CheckAddEnable();
        }


        private void CheckAddEnable()
        {
            btnAdd.Enabled = !btnAdd.Enabled;
            if ((txtFileName.TextLength > 0) && (txtFileSize.TextLength > 0))
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }

        /*
         When user clicks on the ADD button.
            a. -Format a string and store the string into the File System Table.
            b. -Then determine what sector blocks are going to be used for that file.
            c. -Then fill in those particular sectors so the file is stored in the sectors.
            d. -If file needs more than 1 sector, used a linked list approach
            e. -If there aren't enough available sectors then a message box is shown 
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int fileSize = int.Parse(txtFileSize.Text);
            int sectorsNeeded = (int)Math.Ceiling((double)fileSize / MAX_SECTOR_SIZE);
            int availableSectors = 0;
            
            for (int i = 0; i < MAX_Sectors; i++)
            {
                if (string.IsNullOrEmpty(lstSectors.Items[i].ToString()))
                {
                    availableSectors++;
                }
            }



            if (sectorsNeeded > availableSectors)
            {
                MessageBox.Show("There is not enough space to add the file!");
                return;
            }

            // Add file information 
            string fileInfo;
            char hiddenChar = 'h';
            char readOnlyChar = 'r';

            if (chkHidden.Checked == true)
                hiddenChar = 'H';

            if (chkReadOnly.Checked == true)
                readOnlyChar = 'R';

            fileInfo = txtFileName.Text + ", " +
                txtFileSize.Text + ", " + hiddenChar + ", " +
                readOnlyChar;

            List<int> usedSectors = new List<int>();
            int sectorsAdded = 0;

            int prevSector = -1; 
            int nextSector;

            // Calculate which sectors the files are going to use to save the file
            for (int i = 0; i < lstSectors.Items.Count && sectorsAdded < sectorsNeeded; i++)
            {
                if (string.IsNullOrEmpty(lstSectors.Items[i].ToString()))
                {
                    int currentSectorSize;
                    int previousSector = sectorsAdded > 0 ? usedSectors.Last() + 1 : -1;
                    (int nextIndex, int nextSectorNumber) = FindNextAvailableSector(i, usedSectors);

                    if (sectorsAdded == sectorsNeeded - 1)
                    {
                        currentSectorSize = fileSize -(sectorsAdded * MAX_SECTOR_SIZE);
                        nextIndex = -1;
                        nextSectorNumber = -1;
                    }
                    else
                    {
                        currentSectorSize = MAX_SECTOR_SIZE;
                    }

                    string sectorInfo = $"{fileInfo} - Size: {currentSectorSize}, {previousSector}, {nextSectorNumber}";
                    lstSectors.Items[i] = sectorInfo;
                    usedSectors.Add(i);
                    sectorsAdded++;

                    if (nextIndex != -1)
                    {
                        i = nextIndex - 1;
                    }
                }
            }

            string firstSector = usedSectors.First().ToString();
            string lastSector = usedSectors.Last().ToString();
            //fileInfo += $" - First Sector: {firstSector}, Last Sector: {lastSector}";
            lstFileSystem.Items.Insert(0,fileInfo);
            IncrementFileCount();

            fileToSectors.Add(fileInfo, usedSectors);
        }

        private (int, int) FindNextAvailableSector(int currentIndex, List<int> usedSectors)
        {
            for (int i = currentIndex + 1; i < lstSectors.Items.Count; i++)
            {
                if (string.IsNullOrEmpty(lstSectors.Items[i].ToString()) && !usedSectors.Contains(i))
                {
                    return (i, i + 1);
                }
            }
            return (-1, -1);
        }



        // If a file is selected from the fily system list activate remove button
        private void lstFileSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = lstFileSystem.SelectedItem != null;
        }

        private void lstSectors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Click Exit button to exit the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

