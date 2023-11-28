from node import *
import random
from queue import PriorityQueue

class Algorithms:
    def __init__(self):
        self.solution = []
        self.sol_ptr = 0
        self.depth = 1
        self.nodes = 1
        self.check_list = []
        self.explored = []
        self.prev_explored_id = []

    def depth_first_search(self, start_node):
        self.check_list.append(start_node)
        while self.check_list:
            node = self.check_list.pop()
            self.explored.append(node)
            if not start_node.compare(node):
                self.solution.append(node.direction)
                self.depth += 1
                self.nodes += 1
                return
            node.expand()
            neighbor_indices = [i for i in range(len(node.nodes))]
            for _ in range(len(node.nodes)):
                i = random.choice(neighbor_indices)
                neighbor_indices.remove(i)
                if not self.is_in_explored(node.nodes[i]):
                    self.check_list.append(node.nodes[i])
    


    def heuristic(self, node, goal_position):
        pacman_position = node.PacMan.get_position()
        return abs(pacman_position[0] - goal_position[0]) + abs(pacman_position[1] - goal_position[1])

    def find_nearest_food(self, current_position, food_positions):
        current_x, current_y = current_position

        nearest_food_position = None
        nearest_food_distance = float('inf')

        for food_position in food_positions:
            food_x, food_y = food_position
            distance = ((food_x - current_x) ** 2 + (food_y - current_y) ** 2) ** 0.5

            if distance < nearest_food_distance:
                nearest_food_distance = distance
                nearest_food_position = food_position

        return nearest_food_position

    def a_star_search(self, start_node, food_positions):
        open_set = PriorityQueue()
        open_set.put((0, start_node))  # Use a tuple with the priority as the first element

        while not open_set.empty():
            _, current_node = open_set.get()

            nearest_food_position = self.find_nearest_food(start_node.PacMan.get_position(), food_positions)
            if current_node.PacMan.get_position() == nearest_food_position:
                # Goal reached
                self.solution.append(current_node.direction)
                self.depth += 1
                self.nodes += 1
                return

            self.explored.append(current_node)
            current_node.expand()

            for neighbor in current_node.nodes:
                if not self.is_in_explored(neighbor):
                    # Calculate the actual cost for the transition from current_node to neighbor
                    cost = 1  # Replace this with the actual cost calculation based on your rules
                    priority = cost + self.heuristic(neighbor, nearest_food_position)
                    open_set.put((priority, neighbor))

        # No solution found
        print("No solution found.")


    # def breadth_first_search(self, start_node):
    #     self.check_list.append(start_node)
    #     while self.check_list:
    #         node = self.check_list.pop(0)
    #         self.explored.append(node)
    #         if not start_node.compare(node):
    #             self.solution.append(node.direction)
    #             self.depth += 1
    #             self.nodes += 1
    #             return
    #         node.expand()
    #         for i in range(len(node.nodes)):
    #             self.check_list.append(node.nodes[i])
    #             self.nodes += 1
                
    def is_in_explored(self, node):
        for i in range(len(self.explored)):
            if node.compare(self.explored[i]):
                return True
        return False
            
            
    
