create table dbo.products(
  id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  name varchar(255) NULL
);


create table dbo.categories(
  id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  name varchar(255) NULL
);

create table dbo.products_cat(
  product_id int NOT NULL,
  category_id int NOT NULL,

  foreign key (product_id) references dbo.products(id),
  foreign key (category_id) references dbo.categories(id)
);

insert into dbo.products (name) values ('Product 1');
insert into dbo.products (name) values ('Product 2');
insert into dbo.products (name) values ('Product 3');
insert into dbo.products (name) values ('Product 4');
insert into dbo.products (name) values ('Product 5');

insert into dbo.categories (name) values ('Category 1');
insert into dbo.categories (name) values ('Category 2');
insert into dbo.categories (name) values ('Category 3');

insert into dbo.products_cat(product_id, category_id) values (1,1);
insert into dbo.products_cat(product_id, category_id) values (1,2);
insert into dbo.products_cat(product_id, category_id) values (1,3);
insert into dbo.products_cat(product_id, category_id) values (2,2);
insert into dbo.products_cat(product_id, category_id) values (3,1);
insert into dbo.products_cat(product_id, category_id) values (4,3);

SELECT products.name AS ProductName, categories.name AS CategoryName 
FROM dbo.products 
LEFT JOIN dbo.products_cat ON products.id = products_cat.product_id;
LEFT JOIN dbo.categories ON products_cat.category_id = categories.id;

