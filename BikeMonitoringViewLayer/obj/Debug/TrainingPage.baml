   M S B A M L   `   `   `  ����  BikeMonitoringViewLayer*    $BikeMonitoringViewLayer.TrainingPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$$  Bike monitoring - New training��5   	   $	��300��60   $	��300��6=    � 
ResizeMode$ NoResize=�6b    � SizeToContent$ WidthAndHeight=�6x    � WindowStartupLocation$ CenterScreen=�6�    � DataContext 5   	   �� *
Training+.��5      �  � ColumnDefinitions 5   
   �� 5	      $��1* �6   �� 5
      $��2* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $
��Jour��6   $��0��6   $��0��6/   $��Center=�6<   $��Center=�6Y   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpDay��5   D   $��1��6S   $��0��6c   $��Center=�6p   $��Center=�6�      SelectedDate 6   �� 	 �� Path$		 Day�
 �� Mode$
 TwoWay=�6�   �� 5   
   $��Distance (km)��6   $��0��6(   $��1��68   $��Center=�6E   $��Center=�6b   �� 5   
   -   5        $��
tbDistance��5   >   $��1��6P   $��1��6`   $��Center=�6m   $��Center=�6�   $	��200��6�   4  .System.Windows.Automation.AutomationProperties   ItemType$ Float��6�   ��6   �� $	 Distance�$
 TwoWay=�6�   �� 5   
   $��Temps (min)��6   $��0��6&   $��2��66   $��Center=�6C   $��Center=�6`   �� 5   
   -   5        $��tbTime��5   E   $��1��6S   $��2��6c   $��Center=�6p   $��Center=�6�   $	��200��6�   ��6   �� $	 TrainingTimeMin�$
 TwoWay=�6�   �� 5!   
   $��Dénivelé (m)��6   $��0��6'   $��3��67   $��Center=�6D   $��Center=�6a   �� 5"   
   -   5        $��tbHeightDifference��5"   F   $��1��6`   $��3��6p   $��Center=�6}   $��Center=�6�   $	��200��6�   ��6   �� $	 HeightDifference�$
 TwoWay=�6�   �� 5$   
   $��FC moy��6   $��0��6!   $��4��61   $��Center=�6>   $��Center=�6[   �� 5%   
   -   5        $��tbCardiacFAv��5%   M   $��1��6a   $��4��6q   $��Center=�6~   $��Center=�6�   $	��200��6�   ��6   �� $	 CardiacFrequencyAverage�$
 TwoWay=�6�   �� 5'   
   $��FC max��6   $��0��6!   $��5��61   $��Center=�6>   $��Center=�6[   �� 5(   
   -   5        $��tbCardiacFMax��5(   J   $��1��6_   $��5��6o   $��Center=�6|   $��Center=�6�   $	��200��6�   ��6   �� $	 CardiacFrequencyMax�$
 TwoWay=�6�   �� 5*   
   $��Cadence��6   $��0��6"   $��6��62   $��Center=�6?   $��Center=�6\   �� 5+   
   -   5        $��	tbCadence��5+   =   $��1��6N   $��6��6^   $��Center=�6k   $��Center=�6�   $	��200��6�   ��6   �� $	 Cadence�$
 TwoWay=�6�   �� 5-   
   $��Commentaire��6   $��0��6&   $��7��66   $��Center=�6C   $��Center=�6`   �� 5.   
   -	   5        $��	tbGenComm��5.   @   $��1��6Q   $��7��6a   $��Center=�6n   $��Center=�6�   $	��200��6�   ��6   �� $	 
GenComment�$
 TwoWay=�6�   �� 50   
   $��1��6   $��8��6%    �� Orientation$ 
Horizontal=�62   .+�51      �� -
   5        $��bpCancel��51      $��1��6%   $��8��65   $��Annuler��6B   6T   �� 52      -   5        $��
bpValidate��52      $��1��6'   $��8��67   $��Valider��6D   6V   53      54      55      