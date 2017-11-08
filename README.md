# Optimal map classification incorporating uncertainty information

A choropleth map frequently is used to portray the spatial pattern of attributes, and its mapping result heavily relies on map classification. Uncertainty in an attribute has an influence on map classification, and, accordingly, can generate an unreliable spatial pattern. 

The purpose of this project is to develop a tool for an optimal classification result considering data uncertainty in a map classification. Specifically, this project developes optimal classification methods based on a shortest path problem in an acyclic network. These methods utilize dissimilarity measures and various cost and objective functions that simultaneously can consider attribute estimates and their uncertainty. 
Implementation of the proposed methods is in an extension of ArcGIS (compatiable with ArcGIS 10.x, devloped in MS visual studio 2014, and ArcObject 10.5). 

Required software and license: Gurobi optimizer 6.5 or higher

For more detail, please see http://www.tandfonline.com/doi/abs/10.1080/24694452.2016.1261688 
