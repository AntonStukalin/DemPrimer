   M S B A M L   `   `   `  ����E  ABiblioteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Biblioteka
Biblioteka  5   	       Biblioteka.BooksWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Biblioteka     5   	     � Title$  BooksWindow��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	BooksGrid��5
      $
��Left=�6&   $	��399��6A   $��0,10,0,0q�6N   $	��Top=�6`   $	��600��6x      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Автор��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Auther+6O     5      $ Название��6%   $ * 6P    67   �� *Name+6P     5      $ Описание��6%   $ * 6P    67   �� *Text+6P   5      �� 5   
   -   5         ��Name$ AddBtn��5   $   $��Добавить��6   $
��Left=�6I   $��
659,31,0,0q�6d   $	��Top=�6x   $��75��6�   �� 5   
   -   5        $ 
RefreshBtn��5   $   $��Обновить��6   $
��Left=�6Q   $��
659,81,0,0q�6l   $	��Top=�6�   $��75��6�   �� 5   
   -   5        $ 	DeleteBtn��5   #   $��Удалить��6   $
��Left=�6N   $��659,132,0,0q�6i   $	��Top=�6~   $��75��6�   �� 5   
   -   5        $ ExitBtn��5   !   $��
Выход��6   $
��Left=�6H   $��659,371,0,0q�6c   $	��Top=�6x   $��75��6�   5      5      