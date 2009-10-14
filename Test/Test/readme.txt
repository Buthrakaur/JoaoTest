Assumptions:
============

There isn't described if array returned by FindTopNValues should be somehow sorted or not. I assumed that the array should be returned in descending order (and I also implemented unit test according to this assumption).


Design choices:
===============

I was allowed to use .Net 3.5 framework which contains powerful Linq technology so I decided to use it. Its methods for sorting etc are surely much more optimized than anything I would be able to implement on my own in short time.