# DEFINE GLOBAL VARIABLE
balance = 1000

def print_balance(): 
    print(f"BALANCE IS {str(balance)}")

def deduct(amount):
    print(f"UPDATE BALANCE IS {str(balance - amount)}")

# NESTED FUNCTION
def calculate_interest_of_savings():
  saving = 500
  print(f"EARN INTEREST OF: {str(saving)}")
  def calculate_taxes():
    tax_amount = saving * 0.13
    print(f"TAX: {str(tax_amount)}")
  calculate_taxes()

# FUNCTION CALL WITHIN GLOBAL SCOPE
print_balance()
deduct(500)
calculate_interest_of_savings()