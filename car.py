class Car:
    def __init__(self, year_model, make, speed=0):
        self.year_model = year_model
        self.make = make
        self.speed = speed

    def accelerate(self):
        self.speed += 5

    def brake(self):
        self.speed -= 5
    
    def get_speed(self):
        return self.speed

my_car = Car(1982, 'BMW')
for i in range(5):
    my_car.accelerate()
    print(my_car.get_speed())

for i in range(5):
    my_car.brake()
    print(my_car.get_speed())



