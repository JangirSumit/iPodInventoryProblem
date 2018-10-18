# iPod inventory problem solution in C#

There is a company which have started selling the ipods ONLINE . But they want to sell these ipods online at best price.

i) They have ipod Inventories at Brazil and Argentina. Each of the inventory can store only 100 ipods.

ii) ipods at Brazil are sold at 100$/unit and at Argentina they are sold at 50$/unit.

iii) after every order the stock at both brazil and argentina inventories are again back to 100 units.

iv) the no of ipods ordered should be only in multiple of 10.(i.e no of ipods ordered shouldnt be im number like 123 etc. )

v) the order placed should be either fullfilled completely or nothing

vi) if the order is placed like 120 ipods from brazil then the remaining ipods can be brought from the other inventory i.e.argentina. but here shipping price of 400$ per 10 units is applied. 

# Examples

i) Brazil : 5
500 : 95 : 100

ii) Brazil : 50
4500 : 100 : 50
(this trick here is u first have to calculate the cost price at both brazil and argentina..and d one which is low should be given..here argentina)

iii) Argentina : 120
7800 : 80 :20
(this was the case where i made a silly mistake...out of 120 only 100 ipods should be sold according to the price at argentina..while reamaining 20 should be sold at price at brazil which is 100$ + shipping charges (800$))

iv) Argentina : 250
Out of stock!!!!
