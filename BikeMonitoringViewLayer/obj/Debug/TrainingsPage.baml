   M S B A M L   `   `   `  ����  BikeMonitoringViewLayer+    %BikeMonitoringViewLayer.TrainingsPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$   Bike monitoring - Training��5   	    � WindowStartupLocation$ CenterScreen=�6E    � SizeToContent$ Width=�6j   .��5      �  � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��1* �6   .+�5   
   ]� $��0��6   .+�5      o� $	��Top=�6   .@�5      m� $
��Mode��6   .@�5      m� -   5        $��MIWeek��5      $��Semaine��6-   6>   m� 5      -   5        $��MIMonth��5      $
��Mois��6.   6<   m� 5      -   5        $��MIYear��5      $��Année��6-   6<   m� 5      -   5        $��MIAll��5      $��Années cummulées��6,   6F   5      5      �� 5      -   5        $��lvTrainings��5      $
��Auto=�6*   $
��Auto=�6\    �� SelectionMode$ Single=�6�    � ContextMenu 5      �� 5      .@�5      m� -   5        $��Ajouter un entrainement��5      6@   m� 5      -   5        $��Modifier��5      61   m� 5      -	   5        $��	Supprimer��5      62   5       �� View 5       �� 5!      .P�5"      �� $
��Jour��6%    �� DisplayMemberBinding 63   �� *	DayString+�� 5#      $��Distance��6%    67   �� *
Distance+�� 5$      $��Temps (min)��6%    6:   �� *TrainingTimeMin+�� 5%      $
��Km/h��6%    63   �� *	Average+�� 5&      $��
Dénivelé��6%    67   �� *HeightDifference+�� 5'      $��FC moy.��6%    66   �� *CardiacFrequencyAverage+�� 5(      $��FC max.��6%    66   �� *CardiacFrequencyMax+�� 5)      $��Cadence��6%    66   �� *	Cadence+�� 5*      $%��Commentaire général de sortie��6%    6L   �� *
GenComment+5+      5-      5.      �� 51   
   -
   5        $��sPSums��51   "   $��1��6   52      54      55      