   M S B A M L   `   `   `  ����G  CStockGestion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:StockGestion.ViewsStockGestion.Views  5      #    StockGestion.Views.LoginAdmin   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:StockGestion.Views     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  
LoginAdmin��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��56* �6   �� 5      $
��101* �6   �� 5      $	��33* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��Bottom=�5      .+�5      �� $ 
Horizontal=�6   $��Center=�5      .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$
 icon��5   *      Kind$ Account=�5   $   $��80��5   *   $��80��5   *   
�������5   *   5      �� 5      $ 
Horizontal=�6   $��Center=�5      .+�5      �� $��Administrateur��6   
�������$��Center=�5       $��20(�5!      5"      5$      �� 5%   
   $
��Left=�6   $	��303��5&      $	��361��5'      $��Center=�5(      $��	330,0,0,0q�5)      $��1��5*      .+�5+      �� $ Vertical=�6   $��Center=�5,      $��0,50,0,0q�5-      .+�5.      �� $ 
Horizontal=�6   .+�5/      �� -   5         ��Name$ 	mailAdmin��5/      $��	Helvetica)�61   $��Light"�50      $��Adresse mail��51       �� TextWrapping$
 Wrap=�52      $��15(�53      $��Center=�54      
�������
������ $��0q�57      $	��235��58      $
��Left=�59       J� Opacity$	 0.5Q�5:      $��25��5;      $��63,0,0,0q�5<      5=      5>      �� 5?      $	��250��6   $��1��5@      
�������5A      �� 5B      $ 
Horizontal=�6   $��0 20 0 0q�5C      .+�5D      G� -   5         G�Name$ MDPAdmin��5D   "   $��	Helvetica)�64   $��Light"�5E      	 G� Password$	 Password��5F      $��20(�5G      $��Center=�5H      
�������
������ $��0q�5K      $	��235��5L   "   $
��Left=�5M   "   $	 0.5Q�5N   "   $��25��5O   "   $��63,0,0,0q�5P   "   5Q   "   5R      �� 5S      $	��250��6   $��1��5T      
�������5U      �� 5V      $ 
Horizontal=�6   .+�5W      �� -   5        
 ��Name$
 admin_connect��5W      $	��120��64   $��30��5X      $��Se connecter��5Y      $��15(�5Z      $��	50 60 5 0q�5[         styleButton4#��[  5\      5]      �� 5^      -   5        $
 admin_retour��5^      $	��120��63   $��30��5_      $��Retour��5`      $��15(�5a      $��	10 60 0 0q�5b      #��[  5c      6C   5d      5e      5f      5g      5h      