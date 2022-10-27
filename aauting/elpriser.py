import requests
import json
url = "https://api.adlab.dk/api/prices?period=yesterday"
data = requests.get(url).json()
data = data["Records"]
clean_data = []

for point in data:
    if point["PriceArea"] == "DK1":
        clean_data.append(point)


def find_cheapest_consecutive(hour_count: int, price_data: dict) -> set[int]:
    cheapest_price = -1
    cheapest_time = -1
    for i in range(len(price_data) - hour_count):
        current_range = price_data[i:i+hour_count]
        current_price = sum([i["SpotPriceDKK"] for i in current_range])

        if current_price < cheapest_price or cheapest_price == -1:
            cheapest_price = current_price
            cheapest_time = i

    return cheapest_price, cheapest_time


def find_cheapest_random(hour_count: int, price_data: dict) -> list[dict]:
    sorted_prices = sorted(price_data, key=lambda d: d["SpotPriceDKK"])  # Sort by price
    return sorted_prices[:hour_count]  # Return cheapest


def parse_date(date: str) -> str:
    date = date[:-6]  # Remove min and sec
    date = date.replace("T", "  Kl: ")  # Clean time shown
    return date


def consec():
    hour_count = int(input("How many consecutive hours to be on?: "))
    cheapest_price, cheapest_time = find_cheapest_consecutive(hour_count, clean_data)
    cheapest_time = clean_data[cheapest_time]["HourDK"]
    print(f"Cheapest time : {parse_date(cheapest_time)}\nCheapest price: {cheapest_price}")


def random():
    hour_count = int(input("How many random hours to be on?: "))
    cheapest_prices = find_cheapest_random(hour_count, clean_data)
    print("---Cheapest Hours---")
    for p in cheapest_prices:
        print(parse_date(p["HourDK"]))


if __name__ == "__main__":
    random()

