\# Statistics App



Task 5 Explanation:

This merge was not a fast-forward merge because the `main` branch received a new commit (the creation of this README file) after the `feature-max` branch was created. Because the `main` timeline had diverged, Git had to create a new 3-way "merge commit" to combine the two separate histories together without overwriting either of them.

Question 1: 
+ Fast-forward occurs when the target branch has not moved forward since the feature branch was created and Git simply moves the pointer of the main branch to the latest commit
+ Merge Commit is created when the histories have diverged. If a new commit is made on main while you are still working on a feature branch, Git must create a new "3-way merge commit" to tie the two different paths back together

Question 2:
+ When you merge, Git creates a new "Merge Commit" to stitch two branches together. Use Merge if you want to keep a record of exactly how your team collaborated
+ When you rebase, Git takes your branch's commits and moves them to the very tip of the main branch. Use Rebase if you want a clean, simple, and easy-to-read list of changes.
