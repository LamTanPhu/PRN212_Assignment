   M S B A M L   `   `   `  ����  PRN212_Assignment#    PRN212_Assignment.Books.Books   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Books��5   	   $	��683��6   $	��667��6$   .��5      � .+�5   
   �� -   5         ��Name$ searchTextBox��5      $
��Left=�6)   $��	10,10,0,0q�6D   $	��Top=�6W   $	��541��6o   �� 5   
   -   5         ��Name$ searchButton��5      $��Search��6'   $
��Left=�68   $��	579,9,0,0q�6S   $	��Top=�6f   $��75��6~   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ booksDataGrid��5         AutoGenerateColumns$ False��6*   $
��Left=�6F   $	��192��6a   $��	10,50,0,0q�6n   $	��Top=�6�   $	��644��6�      Columns 5	      0  *System.Windows.Controls.DataGridTextColumn  5
      ,  &System.Windows.Controls.DataGridColumn   Header$ Book ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *BookId+  5      $ Title��6%    64   �� *Title+  5      $ Author��6%    65   �� *Author+  5      $ Genre��6%    64   �� *Genre+  5      $ Publication Year��6%    6?   �� *PublicationYear+  5      $ Status��6%    65   �� *Status+5      �� 5   
   $��Book Details��6   $
��Left=�6)   $��
10,247,0,0q�6D   $	��Top=�6X   $	��644��6p   $	��373��6|   .��5      � $	��357��6   .+�5      �� $��Book ID��6   $
��Left=�6*   $��	10,10,0,0q�6E   $	��Top=�6X   �� 5      -   5        $ bookIdTextBox��5      $
��Left=�61   $��
150,10,0,0q�6L   $	��Top=�6`   $	��150��6x   �� 5      $��Title��6   $
��Left=�6(   $��	10,56,0,0q�6C   $	��Top=�6V   �� 5      -   5        $ titleTextBox��5      $
��Left=�60   $��
150,56,0,0q�6K   $	��Top=�6_   $	��150��6w   �� 5      $��Author��6   $
��Left=�6)   $��
10,102,0,0q�6D   $	��Top=�6X   �� 5      -   5        $ authorTextBox��5      $
��Left=�61   $��150,102,0,0q�6L   $	��Top=�6a   $	��150��6y   �� 5      $��Genre��6   $
��Left=�6(   $��
10,148,0,0q�6C   $	��Top=�6W   �� 5      -   5        $ genreTextBox��5      $
��Left=�60   $��150,148,0,0q�6K   $	��Top=�6`   $	��150��6x   �� 5      $��Publication Year��6   $
��Left=�63   $��
10,194,0,0q�6N   $	��Top=�6b   �� 5      -   5        $ publicationYearTextBox��5      $
��Left=�6:   $��150,194,0,0q�6U   $	��Top=�6j   $	��150��6�   �� 5      $��Status��6   $
��Left=�6)   $��
10,240,0,0q�6D   $	��Top=�6X   �� 5      -	   5         ��Name$ statusComboBox��5      $
��Left=�63   $��150,240,0,0q�6N   $	��Top=�6c   $	��150��6{   ��5       �� *StatusOptions+	 �� SelectedItem	 69   �� *SelectedStatus+�� 5#      -
   5        $ addBookButton��5#      $��Add Book��60   $
��Left=�6C   $��
10,286,0,0q�6^   $	��Top=�6r   $	��150��6�   $��39��6�   6�   �� 5$      -   5        $ editBookButton��5$      $��	Edit Book��61   $
��Left=�6E   $��170,286,0,0q�6`   $	��Top=�6u   $	��150��6�   $��39��6�   6�   �� 5%      -   5        $ deleteBookButton��5%      $��Delete Book��63   $
��Left=�6I   $��330,286,0,0q�6d   $	��Top=�6y   $	��150��6�   $��39��6�   6�   5&      5'      5(      5)      