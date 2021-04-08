# Holiday-Planner

Here's my solution for figuring out holidays inside given time periods.

Tech choices:
Using .Net was quite natural choice to me and I decided to spice it up a bit by using .Net 5, although I don't think I used any of the new features in the end. Because code needed to be unit testable, I decided to include a unit test library in the project. I chose to go with NUnit because I've a bit of prior experience with that. This also enabled me to develop the solution as a standalone class library without any UI framework, which was a really cool first time experience for me.

Approach:
I think I got good understanding of the problem right from the start and figured some finer details as I went forward. My approach to development was quite a bit away from TDD as I mostly created tests after developing the features. I could improve a lot by creating testing battery from specification before starting development, which I'll definitely try to do the next time.

Challenges:
- I struggled a bit from analysis paralysis on when starting up. I pondered whether to create a custom date type to simplify out the Time element of DateTime, but I eventually scrapped that idea.
- Early on my code also relied quite a lot on concretions from old habits, which I switched to abstractions later on as I worked my way forward.
- I was about to use base class for national holidays, but decided against using it after figuring out that the days could as well be checked from external API, in which case my hard-coded implementation would already be a hindrance to extensions.

Potential compromises:
- Counting the days could probably have more sophisticated implementation than my scanning approach, but I found this way to be effective and quick to implement.
- Holiday counting could possibly have been abstracted to separate IHolidayCounter, but that is kind of covered by making the whole Holiday Planner an abstraction of IHolidayPlanner.

Conclusion:
I think the end result presents my ability as a developer quite well. I did my best to address what compromises I found and I believe that my solution is capable of getting extended in the future, at least to some extent. I learned a lot about TDD and I'm confident that I'll be able to implement it better the next time.
