Here you can find a number of downloads for the IDEA project with sample code etc:

IDEA Setup file for 64 bits as IdeaSetup64.exe and IdeaSetup64.zip (this includes all the samples and scripts) This version is for all EA 16 or 17 64 bits versions. 
OLD IDEA Setup file for 32 bits as IdeaSetup.exe and IdeaSetup.zip Please use the 32 bits version for previous versions of EA<=15.2 or the 32 bits version of the higher versions (this includes all the samples and scripts)
Sample repository see the installfolder with additional files including an example repository
Download IDEA Sourcecode zipfile
Download IDEA reference file (scripts) import this via de ribbon resource import in Sparx Enterprise Architect
Download the IDEA Sample repository, this is also available in your IDEA install directory. This includes also all the resources already installed in your sample repository.
Please note run the setup executable as administrator

When you have any question or want to have support in configuring the AddOn please do not hesitate to contact us. Please note that IDEA is developed by a community. When you want us to add new features please become part of the community of IDEA users.

Please see the E-learning on tutorials point for this IDEA AddON
 

What actions are performed in the Installmaker:

 

1. To be on the safe side, you can run the ideasetup file as an administrator, then you know for sure that you have the right to modify the GAC and the Registry. Note that Sparx is not running when you run the setup (not even in the background). To be on the safe side, uninstall the previous version of the addon first.

2. Displays a series of dialogs about the installer including asking which directory to install the AddOn.

3. The AddOn unpacks the install file and places these files in the specified directory. In addition, an uninstall executable is created

4. The DLL is then registered in the Windows Global Assembly Cache. This is a kind of registry where all classes and namespaces are installed. The goal is to prevent conflicts in classes with the same name in multiple DLLs. So also the DLLs of Windows itself, and all other installed software. The system function regasm is used for that

5. The class with the link to the Sparx AddOn is then registered for Sparx. This contains several forms for 32 bits and 64 bits and for the current user or for the system (there is a Yes No question in the install maker for this)

6. In the files installed in the folder is an ideaXX.bat file that makes the regasm and regedit actions executable separately from the full install procedure

7. Note that there are some extra items such as an example eapx repository and some stored procedures for SQL server to do simple text analysis for ArchiMate

Best Regards


Bert Dingemans

(bert@interactory.nl)

See more content at https://sparx-wpp.nl
