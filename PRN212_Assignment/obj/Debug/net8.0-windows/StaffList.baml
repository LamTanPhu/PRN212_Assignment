   M S B A M L   `   `   `  ����  PRN212_Assignment!    PRN212_Assignment.StaffList   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Staff List��5   	   $	��502��6   $	��649��6)   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ staffDataGrid��5         AutoGenerateColumns$ False��6*   $
��Left=�6F   $	��Top=�6a   $	��600��6y   $��	10,55,0,0q�6�   $	��197��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Staff ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *	StaffId+  5	      $
 Name��6%    63   �� *Name+  5
      $ Username��6%    67   �� *
Username+  5      $
 Role��6%    63   �� *Role+5      �� 5   
   -   5         ��Name$ searchTextBox��5      $
��Left=�6)   $	��Top=�6D   $	��495��6\   $��	10,10,0,0q�6h   $��23��6{   �� 5   
   -   5        $��Search��5      $
��Left=�6"   $	��Top=�6=   $	��100��6U   $��
510,10,0,0q�6a   6u   �� 5   
   $��Staff ID��6   $
��Left=�6#   $	��Top=�6>   $��
10,276,0,0q�6V   $��26��6j   $��70��6v   �� 5   
   -   5        $ staffIdTextBox��5      $
��Left=�6*   $	��Top=�6E   $��150,276,0,0q�6]   $	��150��6r   $��18��6~   �� 5   
   $
��Name��6   $
��Left=�6   $	��Top=�6:   $��
10,316,0,0q�6R   $��26��6f   $��42��6r   �� 5   
   -   5        $ nameTextBox��5      $
��Left=�6'   $	��Top=�6B   $��150,316,0,0q�6Z   $	��150��6o   $��18��6{   �� 5   
   $��Username��6   $
��Left=�6#   $	��Top=�6>   $��
10,356,0,0q�6V   $��26��6j   $��70��6v   �� 5   
   -   5        $ usernameTextBox��5      $
��Left=�6+   $	��Top=�6F   $��150,356,0,0q�6^   $	��150��6s   $��18��6   �� 5   
   $
��Role��6   $
��Left=�6   $	��Top=�6:   $��
10,396,0,0q�6R   $��26��6f   $��42��6r   �� 5   
   -   5         ��Name$ roleComboBox��5      $
��Left=�6M   $	��Top=�6h   $��150,396,0,0q�6�   $	��150��6�   ��6)   �� *_validRoles+6�   �� 5    
   -   5        $��Update��5       $
��Left=�6"   $	��Top=�6=   $	��100��6U   $��
10,436,0,0q�6a   6u   �� 5!   
   -	   5        $��Delete��5!      $
��Left=�6"   $	��Top=�6=   $	��105��6U   $��120,436,0,0q�6a   6v   5"      5#      