budget = 2000

food_bill = 200
electricity_bill = 100
internet_bill = 300
rent = 500

total = food_bill + electricity_bill + internet_bill + rent

if total > budget: over_budget = True
else: over_budget = False

print(str(total))
print(str(over_budget))