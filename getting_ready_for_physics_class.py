# DATA TO ANALYZE
train_mass = 22680
train_acceleration = 10
train_distance = 100
bomb_mass = 1

# FUNCTION DEFINE TO CONVERT FAHRENHEIT TO CELCIUS
def f_to_c(f_temperature):
    return (f_temperature - 32) * 5 / 9

# FUNCTION DEFINE TO CONVERT CELCIUS TO FAHRENHEIT
def c_to_f(c_temperature):
    return c_temperature * 9 / 5 + 32

# FUNCTION DEFINE TO GET FORCE
def get_force(mass, acceleration):
    return mass * acceleration

# FUNCTION DEFINE TO GET ENERGY
def get_energy(mass, c = 3 * 10 ** 8):
    return mass * c ** 2

# FUNCTION DEFINE TO GET WORK
def get_work(mass, acceleration, distance):
    return get_force(mass, acceleration) * distance

# VARIABLES FOR OUTPUT
f100_in_celcius = f_to_c(100)
c0_in_fahrenheit = c_to_f(0)
train_force = get_force(train_mass, train_acceleration)
bomb_energy = get_energy(bomb_mass)
train_work = get_work(train_mass, train_acceleration, train_distance)

print(f"TRAIN FORCE {train_force} N")
print(f"BOMB ENERGY {bomb_energy} J")
print(f"TRAIN WORK IS {train_work} J OF WORK OVER {train_distance} m.")