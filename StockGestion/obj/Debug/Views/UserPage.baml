   M S B A M L   `   `   `  ����G  CStockGestion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:StockGestion.ViewsStockGestion.Views  5      !    StockGestion.Views.UserPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:StockGestion.Views     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          N� Title$  UserPage��5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��9* �6    � ColumnDefinitions 5   
   �� 5      $
��273* �6   �� 5      $
��751* �6   .+�5   
   �� $��0��6   $��2��6!   ��5      �� 5      .��5      �  � Color$ 	#FF1B247A��6#    � Offset$ 0.394Q�65   � 5      $ 	#FF4D0C39��6#   $ 1Q�65   5      5      �� 5   
   $��1��6   ���	#FFC9CFC6$��2��68   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�5       $��0,20,0,0q�5!      .+�5"      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ iconMenu��5"   &      Kind$
 Menu=�5#   $   $��40��5$   *   $��40��5%   *   
�������5&   *   5'      �� 5(   
   $��1��6   $��0,36,0,0q�6"   .+�5)      �� -   5         ��Name$ vente��5)      $��Ventes��6$   $	��270��5*   &   $��50��5+   &   $��20(�5,   &   $��Monotype Corsiva)�5-   &      styleButton5#��[  5.   &   6L   �� 50      -   5        $ 
prodFaible��50      $��Produits Faibles��6)   $	��270��51   &   $��50��52   &   $��20(�53   &   $��Monotype Corsiva)�54   &   #��[  55   &   56   &   �� 5=      -   5        $ stock��5=      $��Stocks��6$   $	��270��5>   &   $��50��5?   &   $��20(�5@   &   $��Monotype Corsiva)�5A   &   #��[  5B   &   6L   �� 5E      -   5        $ quitter��5E      $��Quitter��6&   $	��270��5F   &   $��50��5G   &   $��20(�5H   &   $��Monotype Corsiva)�5I   &   #��[  5J   &   6L   5M      � 5N   
   $��1��6   $��2��6   .+�5O       � -   5        	  �Name$	 PageInfoUser��5O      
  � NavigationUIVisibility$
 Hidden=�6*   5P      5Q      5R      