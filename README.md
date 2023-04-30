# Ganther_FCG

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
