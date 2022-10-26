def recursion_sum(number) -> int:
    if number == 1:
        return 1
    return number + recursion_sum(number-1)


if __name__ == "__main__":
    number = int(input("Gib numbber plz: "))
    print(recursion_sum(number))
