def weird_sum(number: int):
    return sum([i for i in range(number) if i % 3 == 0 or i % 5 == 0])


if __name__ == "__main__":
    number = int(input("Gib numbber plz: "))
    print(weird_sum(number))
