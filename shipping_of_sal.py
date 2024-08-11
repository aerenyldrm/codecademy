weight = 4.8
# GROUND SHIP
if weight <= 2: print(20 + weight * 1.5)
elif weight <= 6: print(20 + weight * 3)
elif weight <= 10: print(20 + weight * 4)
else: print(20 + weight * 4.75)
cost_premium_ground_shipping = 125
print(cost_premium_ground_shipping)
# DRONE SHIP
if weight <= 2: print(weight * 4.5)
elif weight <= 6: print(weight * 9)
elif weight <= 10: print(weight * 12)
else: print(weight * 14.25)