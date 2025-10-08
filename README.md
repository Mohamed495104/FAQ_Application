FAQ + Tutorial + Trip Log Application

Completed till Project 6-2.
Pending: Project 7-1 & 8-1 as per the assignment requirement document

📝 Detailed Implementation Steps
Project 6-1: FAQ App (Conventional Routing)
Key Requirements:

✅ Bootstrap navbar for topic filtering
✅ Bootstrap list group for category filtering
✅ EF Core with Code First migrations
✅ Seed data for topics, categories, FAQs
✅ Lowercase URLs with trailing slashes
✅ Foreign key relationships

Implementation Steps:

Create model classes (FAQ, Topic, Category)
Setup DbContext with relationships
Configure routing (lowercase, trailing slash)
Create seed data
Build Index view with navbar & list group
Implement filtering logic in controller
Style with Bootstrap + custom CSS


Project 6-2: FAQ App (Attribute Routing)
Key Requirements:

✅ Convert to attribute routing
✅ Remove "home/index" from URLs
✅ Multiple route attributes on Index() method
✅ Order attributes from most to least specific

Routes to Implement:

/ - All FAQs
/topic/{id}/ - Filter by topic
/category/{id}/ - Filter by category
/topic/{id}/category/{catId}/ - Filter by both

Implementation Steps:

Copy Project 6-1
Modify Program.cs routing configuration
Add multiple [Route] attributes to Index() action
Update view links to match new routes
Test all route combinations


Project 7-1: MyWebsite App
Key Requirements:

✅ Areas (Help area)
✅ Nested layouts (_Layout.cshtml & _HelpLayout.cshtml)
✅ Layout sections (header with h1)
✅ Bootstrap navbar with active link highlighting
✅ Bootstrap tabs in Help area
✅ No models/database needed

Implementation Steps:

Create main layout with navbar & section
Setup Help area with nested layout
Configure area routing in Program.cs
Create Contact view with data from controller
Implement Tutorial controller with dynamic view selection
Add active link/tab highlighting
Style with Bootstrap + custom CSS


Project 8-1: Trips Log App
Key Requirements:

✅ Multi-step form (3 pages)
✅ ViewModels for each page
✅ TempData for persistence between requests
✅ ViewBag for layout subhead
✅ Conditional page 2 display
✅ Single table database design

Implementation Steps:

Create Trip model (single table)
Create ViewModels for each step
Setup DbContext and migrations
Build 3-page form flow
Implement TempData storage/retrieval
Add conditional page 2 logic
Implement Save/Cancel functionality
Display success message on Index
Style with Bootstrap + custom CSS
