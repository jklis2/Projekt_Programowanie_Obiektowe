   M S B A M L   `   `   `  ����	  Sklep%    Sklep.Views.Edytowanie_produktu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5        � Title$  Edytowanie produktu��5      $	��800��6!   $
��1000��6.   .��5
      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   �� $��Nazwa produktu:��6   $
��Left=�6*   $��	10,55,0,0q�6E   $	��Top=�6X   $
��Bold"�6p   �� 5   
   -   5         ��Name$ Nazwa_produktu_Text��5      $
��Left=�6/   $��
112,55,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $��TextBox��6r   $	��Top=�6�   $	��501��6�   �� 5   
   $��Opis produktu:��6   $
��Left=�6)   $��	10,92,0,0q�6D   $	��Top=�6W   $
��Bold"�6o   �� 5   
   $��Cena produktu:��6   $
��Left=�6)   $��
10,165,0,0q�6D   $	��Top=�6X   $
��Bold"�6p   �� 5   
   $��Ilość sztuk w sklepie:��6   $
��Left=�61   $��
10,197,0,0q�6L   $	��Top=�6`   $
��Bold"�6x   �� 5   
   $��Data kolejnej dostawy:��6   $
��Left=�61   $��
10,233,0,0q�6L   $	��Top=�6`   $
��Bold"�6x   �� 5   
   -   5        $ Cena_produktu_Text��5      $
��Left=�6.   $��102,165,0,0q�6I   $
 Wrap=�6^   $��TextBox��6r   $	��Top=�6�   $	��100��6�   �� 5   
   -   5        $  Ilosc_sztuk_w_sklepie_Text��5      $
��Left=�66   $��132,197,0,0q�6Q   $
 Wrap=�6f   $��TextBox��6z   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ Opis_produktu_Text��5      $
��Left=�6.   $��
100,92,0,0q�6I   $
 Wrap=�6]   $��TextBox��6q   $	��Top=�6�   $	��878��6�   %  DevExpress.Xpf.Editors.DateEdit  5   
   -   5          Name$  Data_kolejnej_dostawy_Text��5      $
��Left=�6;   $��143,233,0,0q�6V   $	��Top=�6k   $��22��6�   $	��109��6�   6�   �� 5   
   $��Kategoria produktu:��6   $
��Left=�6.   $��
10,130,0,0q�6I   $	��Top=�6]   $
��Bold"�6u   �� 5   
   -   5         ��Name$ Kategoria_produktu_Text��5      $
��Left=�64   $��129,130,0,0q�6O   $	��Top=�6d   $	��120��6|    �� DisplayMemberPath$ nazwa_kategorii��6�    �� SelectedItem 6�   �� *id_kategorii+6�   &   DevExpress.Xpf.Core.SimpleButton  5   
   -   5        	  Name$	 Zapisz��5      $��Zapisz��6*   $
��Left=�6;   {�.  $��773,289,0,0q�6h   $	��Top=�6}   $	��130��6�   $��40��6�   
   Glyph
 6�   *  $DevExpress.Xpf.Core.DXImageExtension  *SvgImages/Save/Save.svg+6�   �� 5   
   $��Nazwa producenta:��6   $
��Left=�6,   $��
10,271,0,0q�6G   $	��Top=�6[   $
��Bold"�6s   �� 5    
   -   5        $ Nazwa_producenta_Text��5       $
��Left=�62   $��124,271,0,0q�6M   $	��Top=�6b   $	��120��6z   $ nazwa_producenta��6�    6�   �� *id_producenta+6�   �� 5!   
   $��Nazwa dostawcy:��6   $
��Left=�6*   $��
10,307,0,0q�6E   $	��Top=�6Y   $
��Bold"�6q   �� 5"   
   -	   5        $ Nazwa_dostawcy_Text��5"      $
��Left=�60   $��112,307,0,0q�6K   $	��Top=�6`   $	��120��6x   $ nazwa_dostawcy��6�    6�   �� *id_dostawcy+6�   �� 5#   
   -
   5        $ Nazwa_produktu_Text1��5#      $
��Left=�61   $��
114,16,0,0q�6L   $	��Top=�6`   $	��120��6x   $ nazwa_produktu��6�    6�   �� *id_produktu+6�   �� 5$   
   $��Wybierz produkt:��6   $
��Left=�6+   $��	10,16,0,0q�6F   $	��Top=�6Y   $
��Bold"�6q   5&      5'      