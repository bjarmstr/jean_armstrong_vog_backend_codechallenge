# jean_armstrong_vog_backend_codechallenge

An app following the instructions provided in the Vog CodeChallengeV4

## How to run


This is a simple app, there are no external dependencies necessary to include in order to run.  All questions are tagged and available through the dev branch.

## Q1: 

I would ask the team if there was a typo in the solution name -- assumed I got a response of yes.  So I named my app _vog_backend_codechallenge  NOT vog_backend_codechalleneg

## Q4:  

I left the exception handling until question 11 but I should have built a try catch block into the controller to catch NotFoundErrors.  Also, I should have added capability for comments to show in swagger view.

## Q5:  

I don't have much experience with projects not using a database as a memory store.  Putting the seed data into the service was a poor decision as it was not extendable.  I should have put it in a separate class.  I was unable to seed my ApplicationDbContext after I built it and beacuse of this, I was unable to just delete the original seed data.  This was taking too much of my time so I skipped this question and left it until the end.  

The inMemory datastore is not working as well as a postgres database.  It does not restrict an Employee to use an existing DepartmentId.  I could run a check before creation of the employee to make sure it exists and throw a validation error if it doesn't.