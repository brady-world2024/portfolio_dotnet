
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PortfolioContext context){
            if(context.Projects.Any()) return;
            var projects = new List<Project>{
                new Project{
                    Name = "My Zone",
                    Description = "'My Zone' is a website that offers a dynamic and interactive platform with a wide range of features aimed at providing an engaging user experience. The website is divided into 14 distinct sections, each catering to specific content categories. After registering, users can post content in their respective sections, including text, images, and more.",
                    PictureUrl = "/images/myzone.jpg",
                    GitHubUrl = "https://github.com/brady-world2024/myZonePrivate",
                    Url = "http://3.88.10.109/",
                    Detail = @"'My Zone' is a website that offers a dynamic and interactive platform with a wide range of features aimed at providing an engaging user experience. The website is divided into 14 distinct sections, each catering to specific content categories. After registering, users can post content in their respective sections, including text, images, and more.

                                Key features include:

                                User Interactions: Registered users can engage with posts by liking, commenting, and sharing their thoughts. This promotes a community-driven experience, allowing users to actively contribute and interact with content.

                                Search Functionality: Users can search for posts based on their interests, making it easy to find relevant content across different sections.

                                Content Management: The website also offers robust administrative features. The admin panel allows for managing the website's data, including the addition and removal of banners on the homepage, as well as moderating posts and comments.

                                User Management: Administrators can manage user accounts, ensuring a smooth and secure operation of the platform.

                                Data Analytics: The backend also includes a data analytics feature, providing insights into website traffic, user activity, and content engagement, which helps improve the user experience and optimize site performance.

                                Overall, 'My Zone' provides a well-rounded platform with extensive functionality for both users and administrators, enhancing both the content-sharing experience and the site management capabilities."
                },
                new Project{
                    Name = "Image Gallery",
                    Description = "'Image Gallery' is a dynamic platform that allows users to share their photographs, AI-generated images, and artwork. With a user-friendly interface and engaging features, it provides a comprehensive space for creative expression.",
                    PictureUrl = "/images/imagegallery.jpg",
                    GitHubUrl = "https://github.com/brady-world2024/ImageGallery",
                    Url = "/images/imagegallery.jpg",
                    Detail = @"'Image Gallery' is a dynamic platform that allows users to share their photographs, AI-generated images, and artwork. With a user-friendly interface and engaging features, it provides a comprehensive space for creative expression.
                            Key features include:
                            User Registration and Login: Users can register and log in to gain access to personalized features, including managing their uploaded content and personal homepage.
                            Sectioned Content: The website is organized into three distinct sections: Photos, AI Creations, and Paintings, allowing users to categorize their artwork based on type.
                            Browse Without Logging In: Users who are not logged in can still browse through others' works, fostering a community-driven environment.
                            Personal Homepage: Upon logging in, users gain access to their personal homepage where they can view and manage all their previously uploaded images.
                            Upload and Manage Images: Logged-in users can easily upload new images, select the appropriate section for each piece, and delete old images from their collection.
                            Dynamic Image Display: Each image is showcased with a sleek and dynamic loading effect, enhancing the visual appeal and creating a more engaging browsing experience.
                            This platform provides users with the tools to manage, showcase, and share their artwork with others, all while enjoying an aesthetically pleasing and user-friendly experience."
                },
                    new Project{
                    Name = "Encryption-Based Messaging",
                    Description = "This software provides secure communication with advanced encryption methods, offering users a reliable platform for both private and group messaging.",
                    PictureUrl = "/images/chatapp.jpg",
                    GitHubUrl = "https://github.com/brady-world2024/ChatApp",
                    Url = "/images/sorry.jpg",
                    Detail = @"This software provides secure communication with advanced encryption methods, offering users a reliable platform for both private and group messaging.
                            Key features include:
                            Server Selection: Users can choose the server's IP address from a list of deployed servers located at different IP addresses, offering flexibility in connection options.
                            Customizable Ports: Users can select from a range of open ports for communication, ensuring convenience and adaptability in the connection process.
                            Multiple Encryption Methods: The software offers three encryption options—Caesar Cipher, DES Encryption, and AES Encryption—allowing users to select the appropriate level of security for their communication needs.
                            Private Messaging: Secure one-on-one messaging, ensuring all personal conversations are protected with strong encryption protocols.
                            Group Chat Support: In addition to private messaging, the software enables group chats, allowing users to securely communicate with multiple participants in real-time.
                            Real-Time Communication: The software ensures that all communication, whether private or in a group, remains confidential and is protected from unauthorized access.
                            This encryption-based messaging software provides users with the freedom to customize their connection settings, while ensuring that all communications are securely encrypted and protected from potential threats."
                   },
                   new Project{
                    Name = "Bug World Simulation",
                    Description = "Bug World is an immersive simulation that recreates a dynamic ecosystem where plant and insect life evolve in a balanced environment. The simulation is divided into three main categories: herbivorous insects, carnivorous insects, and plants.",
                    PictureUrl = "/images/bugworld.jpg",
                    GitHubUrl = "https://github.com/brady-world2024/AnimatingBugWorld",
                    Url = "/images/sorry.jpg",
                    Detail = @"Bug World is an immersive simulation that recreates a dynamic ecosystem where plant and insect life evolve in a balanced environment. The simulation is divided into three main categories: herbivorous insects, carnivorous insects, and plants.
                            In the world of Bug World:
                            Plants grow and develop over time, becoming larger as they age.
                            Herbivorous insects feed on plants, exploring their environment to find the nearest food source.
                            Carnivorous insects hunt herbivorous insects, providing a natural predator-prey dynamic.
                            Each type of insect has its own food-searching range, and as they consume food, they grow and increase in size. However, if insects or plants are eaten by others, they shrink until they eventually die.
                            Key features of the simulation include:
                            Time control: Users can speed up or slow down the passage of time, allowing them to observe the growth and interaction between plants and insects at different speeds.
                            Atmospheric music: The software features ambient music that enhances the immersive experience, making users feel as though they are right there in the world of Bug World.
                            With these features, Bug World offers a fascinating and interactive way to explore the complex relationships between plants and insects in a self-sustaining ecosystem.
                            "
                   },
                    new Project{
                    Name = "Binary Tree Visualization",
                    Description = "This software provides an intuitive and interactive way to visualize and understand binary tree structures by using names as the key data. The software takes a list of names from a given document and organizes them in a binary tree, enabling a clear, graphical representation of how binary trees work.",
                    PictureUrl = "/images/binarytree.jpg",
                    GitHubUrl = "https://github.com/brady-world2024/BinaryTree",
                    Url = "/images/sorry.jpg",
                    Detail = @"This software provides an intuitive and interactive way to visualize and understand binary tree structures by using names as the key data. The software takes a list of names from a given document and organizes them in a binary tree, enabling a clear, graphical representation of how binary trees work.
                            Key features include:
                            Name Insertion: Users can add names to the binary tree, and the names will be automatically sorted in the correct position according to binary tree properties.
                            Name Search: The software provides a fast search feature, allowing users to quickly find specific names within the tree.
                            Balance Binary Tree: The program includes a balancing function to ensure the binary tree is optimized for performance, improving search and insertion operations.
                            Visualization: The software offers a graphical representation of the tree, helping users to better understand the organization and sorting of data in a binary tree structure.
                            This tool is ideal for those looking to understand binary trees in a visual and easy-to-understand manner, with functionalities designed to reinforce key binary tree concepts, such as insertion, search, and balancing. It serves as a valuable educational tool for both beginners and advanced learners of computer science."
                   },
                    new Project{
                    Name = "Number Guessing Game",
                    Description = "This is a fun and engaging number guessing game where each round, the software randomly generates a secret number within a range from 1 to 100. The player’s goal is to guess the number as quickly as possible.",
                    PictureUrl = "/images/numberguessing.jpg",
                    GitHubUrl = "https://github.com/brady-world2024/NumberGuessingGame",
                    Url = "/images/sorry.jpg",
                    Detail = @"This is a fun and engaging number guessing game where each round, the software randomly generates a secret number within a range from 1 to 100. The player’s goal is to guess the number as quickly as possible.
                                Key features of include:
                                Random Number Generation: Each game round features a new randomly generated number between 1 and 100.
                                Feedback on Guesses: After each guess, the game provides feedback, telling the player if their guess was too high, too low, or correct.
                                Tracking Time and Attempts: The game records the time taken and the number of attempts made to guess the correct number, allowing players to challenge themselves for better results.
                                Relaxing Music: The game includes soothing background music, creating a light and enjoyable atmosphere for players.
                                This game is perfect for anyone looking for a fun, casual experience that also offers a bit of a challenge in guessing numbers. It’s easy to play, but can keep you coming back to improve your time and guesses!"
                   },

            };
            foreach (var project in projects){
                context.Projects.Add(project);
            }
            context.SaveChanges();
        }
    }
}