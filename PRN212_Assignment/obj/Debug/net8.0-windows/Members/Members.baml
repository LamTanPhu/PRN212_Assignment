   M S B A M L   `   `   `  ����  PRN212_Assignment'    !PRN212_Assignment.Members.Members   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Members��5   	   $	��508��6   $	��643��6&   .��5      � $��	0,0,10,-6q�6    � ColumnDefinitions 5   
   �� 5      $
��169* �6   �� 5      $	��37* �6   .+�5
   
   �� -   5         ��Name$ searchTextBox��5
      $��	0,17,96,0q�6)   $	��Top=�6<   $��Right=�6T   $	��503��6p   $��2��6|   $��18��6�   �� 5   
   -   5         ��Name$ searchButton��5      $��Search��6'   $��
26,16,25,0q�68   $	��Top=�6L   $��1��6   $��19��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ membersDataGrid��5         AutoGenerateColumns$ False��6,   $	��200��6H   $��	19,55,0,0q�6U   $	��Top=�6h   $
��Left=�6�   $	��589��6�   $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Member ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
MemberId+  5      $
 Name��6%    63   �� *Name+  5      $ Contact Information��6%    6B   �� *ContactInformation+5      �� 5   
   $��	Member ID��6   $
��Left=�6$   $��
10,276,0,0q�6?   $	��Top=�6S   $��26��6k   $��70��6w   �� 5   
   -   5        $ memberIdTextBox��5      $
��Left=�6+   $��150,276,0,0q�6F   $	��Top=�6[   $	��150��6s   $��18��6   �� 5   
   $
��Name��6   $
��Left=�6   $��
10,316,0,0q�6:   $	��Top=�6N   $��26��6f   $��42��6r   �� 5   
   -   5        $ nameTextBox��5      $
��Left=�6'   $��150,316,0,0q�6B   $	��Top=�6W   $	��150��6o   $��18��6{   �� 5   
   $��Contact Information��6   $
��Left=�6.   $��
10,356,0,0q�6I   $	��Top=�6]   $��26��6u   $	��116��6�   �� 5   
   -   5        $ contactInfoTextBox��5      $
��Left=�6.   $��150,356,0,0q�6I   $	��Top=�6^   $	��150��6v   $��18��6�   �� 5   
   -   5        $ addMemberButton��5      $��
Add Member��6*   $
��Left=�6?   $��
10,392,0,0q�6Z   $	��Top=�6n   $	��150��6�   $��50��6�   6�   �� 5   
   -   5        $ editMemberButton��5      $��Edit Member��6+   $
��Left=�6A   $��170,392,0,0q�6\   $	��Top=�6q   $	��150��6�   $��50��6�   6�   �� 5   
   -	   5        $ deleteMemberButton��5      $��Delete Member��6-   $
��Left=�6E   $��331,392,0,0q�6`   $	��Top=�6u   $	��150��6�   $��50��6�   6�   5      5      