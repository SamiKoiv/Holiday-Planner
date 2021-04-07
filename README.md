# Holiday-Planner

Here's my solution for figuring out holidays inside given time periods.

Given that I spent 4,5 h on the development task I went well overboard the goal of 2-3 hours.
I think I got good understanding of the problem right from the start and figured some finer details as I went forward.

Using .Net was quite natural choice to me and I decided to spice it up a bit by using .Net 5, although I don't think I used any of the new features after all.
Because code needed to be unit testable, I decided to include a unit test library in the project. I chose to go with NUnit because I've had a little prior experience with that.
This also enabled me to develop the solution as a standalone class library without any UI layer, which was a really cool first time experience for me.

I struggled a bit from analysis paralysis on when starting up, especially when I pondered whether to create a custom type to use instead of DateTime, eventually scrapping that idea.
My approach to development was quite far from TDD as I mostly created tests after developing the features so that's one thing to improve in the future.
Early on my code also relied quite a lot on concretions, which I switched to abstractions later.
I think that while my solution feels pretty good, it might seem a bit of an awkward take on SOLID and TDD, which I haven't implemented too often.
One specific point that I'm unsure about is the entry point to the logic, which feels a bit heavy to set up while having the positive side of being quite modular.

Since I spent some extra time on the task, I think the end result presents my ability as a developer quite well. I did my best to address what compromises I found and what's left is some aforementioned awkwardness in details, like how the dates are currently hardcoded (hence labeled with test) but hopefully they wouldn't obstruct developing over these abstractions later, which is kinda the main idea.
