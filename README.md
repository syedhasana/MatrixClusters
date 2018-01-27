#This is similar to Zombie Clusters problem. Two entities are said to be related if they both exhibit similar characteristics. Given the set of relationships between entities, the task is to find the total number of mutually exclusive clusters of related objects. #The relationship propert is transitive, i.e., if entity A is related to entity B and B is related to entity is C, then A and C are related as well and all 3 entities will be counted as a single cluster. If an entity is not related to any other given entities, it will form its own cluster.
In this problem, the input consists of 2 dimensional matrix. The dimension represents the number of entities. The value '1' means the corresponding indices are related.
CONSTRAINTS: 
  Diagonal values within the input array will all be 1s as an entity is related to itself.
  Entry(i, j) = Entry(j, i), where i is not equal to j.
