   M S B A M L   `   `   `  ����D  @SmartSort, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SmartSort	SmartSort  5          SmartSort.RuleWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:SmartSort     5      $	��450��5   7   $	��340��6C     � 	Resources  5	          BooleanToVisibilityConverter��%   &	        �� 5
   
   6'   5      .��5      � ���#e5e5e5.+�5   
   �� -   5         ��Name$ 
rulesLabel��5      $��Rules:��6$   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6c   $��23��6{   �� 5   
   -   5         ��Name$ comboBox_Rules��5      $ �� IsSynchronizedWithCurrentItem$
 TrueY�6+   $
��Left=�6�   $	��Top=�6  $	��370��6#  $��
88,10,-8,0q�6/  $��23��6C  ��6P   �� *SomeBindingPropertyList+ �� SelectedItem 6�   �� *&$SomeBindingPropertySelectedCurrently+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6C  �� 5   
   -   5        $ TitLabel��5      $��Title:��6"   $
��Left=�63   $��	10,38,0,0q�6N   $	��Top=�6a   $��23��6y   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>   $��	88,38,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��352��6�   �� 5   
   -   5        $ sourcesLabel��5      $��Sources:��6&   $
��Left=�69   $��	10,66,0,0q�6T   $	��Top=�6g   $��23��6   �� 5   
   -   5        $ 	comboBox1��5      $
��Left=�6&   $	��Top=�6A   $	��290��6Y   $��	88,66,0,0q�6e   $��23��6x   �� 5   
   -   5        	 ��Name$	 button1��5      $��+��6"   $
��Left=�6.   $	��Top=�6I   $��35��6a   $��
365,66,0,0q�6l   $��23��6�   ���	#FFEA8F23
�������6�   �� 5   
   -   5        $	 button2��5      $��-��6"   $
��Left=�6.   $	��Top=�6I   $��35��6a   $��
405,66,0,0q�6l   $��23��6�   ���	#FFEA8F23
�������6�   �� 5   
   -	   5        $ 	destLabel��5      $��Destination:��6#   $
��Left=�6:   $��	10,94,0,0q�6U   $	��Top=�6h   $��23��6�   �� 5   
   -
   5        $ textBox2��5      $
��Left=�6$   $��23��6?   $��	88,94,0,0q�6K   $
 Wrap=�6^   $	��Top=�6r   $	��272��6�   �� 5   
   -   5        $	 button_Copy��5      $��Browse��6&   $
��Left=�67   $	��Top=�6R   $��75��6j   $��
365,94,0,0q�6u   $��23��6�   ���	#FFEA8F23
�������6�   �� 5   
   -   5        $ destLabel_Copy��5      $��Keyword:��6(   $
��Left=�6;   $��
10,122,0,0q�6V   $	��Top=�6j   $��23��6�   �� 5   
   -   5        $ textBox2_Copy��5      $
��Left=�6)   $��23��6D   $��
88,122,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��352��6�   �� 5   
   -   5        $ destLabel_Copy1��5      $��
Extension:��6)   $
��Left=�6>   $��
10,150,0,0q�6Y   $	��Top=�6m   $��23��6�   �� 5   
   -   5        $ comboBox_Copy��5      $
��Left=�6*   $	��Top=�6E   $	��370��6]   $��88,150,-8,0q�6i   $��23��6~   �� 5   
   -   5        
 ��Name$
 listBox��5      $
��Left=�6#   $	��152��6>   $��
88,178,0,0q�6K   $	��Top=�6_   $	��272��6w   .@�5      �� $��Include folders��6   �� 5      $��Fodlers need the key��6   �� 5      $��Keep the source��6   �� 5       $��Replace files��6   �� 5!      $��All from key folders��6   5"      �� 5#   
   -   5        $ destLabel_Copy2��5#      $��Rules:��6)   $
��Left=�6:   $��
10,178,0,0q�6U   $	��Top=�6i   $��23��6�   �� 5$   
   -   5        $	 button_Copy1��5$      $��	Save rule��6'   $
��Left=�6;   $	��Top=�6V   $��75��6n   $��365,307,0,0q�6y   $��23��6�   ���	#FFEA8F23
�������6�   �� 5%   
   -   5        $	 button_Copy2��5%      $��Delete Rule��6'   $
��Left=�6=   $	��Top=�6X   $��75��6p   $��365,279,0,0q�6{   $��23��6�   ���	#FFEA8F23
�������6�   5'      5(      