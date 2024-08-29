def exponents(bases, powers):
    exponents_values = []
    for base in bases:
        for power in powers: exponents_values.append(base ** power)
    return exponents_values

print(exponents([2, 3, 4], [1, 2, 3]))