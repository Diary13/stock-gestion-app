   M S B A M L   `   `   `  ����G  CStockGestion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:StockGestionStockGestion  5   	       StockGestion.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:StockGestion     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  
MainWindow��5	   	   $	��600��6   $
��1024��6)    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��570 �6   .+�5   
   �� $��2��6   ��5      �� 5      .��5      �  � Color$ 	#FF152068��6#    � Offset$ 0.394Q�65   � 5      $ 	#FF4D0C39��6#   $ 1Q�65   5      5      � 5   
   ���	#FF040B3C.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�5       $��55��5!      .+�5"      �� -   5        	 ��Name$
	 quit��5"      $��55��6(   $
��Auto��5#   $   $��0q�5'   $   ��5$   $   Z� ��5%   $   Z� .��5(      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        
  Name$

 icon��5(   .      Kind$ Power=�5)   $   $��25��5*   *   $��25��5+   *   5,      5-      �� 5.      $ 
Horizontal=�6   $��center=�5/      $	��100��50      .+�51      �� $��Stock Gestion App��6   
�������$��Center=�53      54      55      � 56   
   $��1��6   .+�57       � -   5          �Name$
 Info��57        � NavigationUIVisibility$ Hidden=�6"   58      5;      5<      