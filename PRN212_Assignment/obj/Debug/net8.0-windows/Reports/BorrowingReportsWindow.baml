   M S B A M L   `   `   `  ����L  HPRN212_Assignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:PRN212_Assignment.ReportsPRN212_Assignment.Reports  5   	   6    0PRN212_Assignment.Reports.BorrowingReportsWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:PRN212_Assignment.Reports     5   	     � Title$  Borrowing Reports��5   	   $	��597��6#   $	��457��60   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dgBorrowings��5
         AutoGenerateColumns$
 True��6'   $
��Left=�6B   $	��Top=�6]   $��	20,51,0,0q�6u   $	��416��6�   $	��246��6�   6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��	20,13,0,0q�6a   .+�5      (  "System.Windows.Controls.DatePicker  -   5        $��dpStartDate��5      $	��150��6,   �� 5      $��to��6   $
��10,0q�6"   $��Center=�60     5      -   5        $��	dpEndDate��5      $	��150��6*   �� 5      -   5        $��Filter��5      $
��10,0q�6;   �� 5      -   5        $��Clear��5      6%   5      �� 5   
   $ Vertical=�6   $
��Left=�6,   $	��Top=�6G   $��
20,320,0,0q�6_   .+�5      �� $��Borrowing Details��6   $��16(�61   $
��Bold"�6?   �� 5      $��Borrowing ID:��6   �� 5      -   5        $��txtBorrowID��5       �� 
IsReadOnly$
 True��6)   �� 5      $��Book ID:��6   �� 5      -   5        $��	txtBookID��5      �� 5      $��
Member ID:��6   �� 5      -   5        $��txtMemberID��5      �� 5      $��Borrow Date:��6     5      -	   5        $��dpBorrowDate��5      �� 5      $��Return Date:��6     5      -
   5        $��dpReturnDate��5      5       �� 5"   
   -   5        $��Update��5"      $
��Left=�67   $	��Top=�6R   $��
20,539,0,0q�6j   $��65��6~   �� 5#   
   -   5        $��Add Borrowing��5#      $��Center=�6D   $	��Top=�6a   $��	0,539,0,0q�6y   $	��110��6�   �� 5$   
   -   5        $
��Back��5$      $
��Left=�63   $	��Top=�6N   $��342,536,0,0q�6f   $��25��6{   $��94��6�   5%      5&      