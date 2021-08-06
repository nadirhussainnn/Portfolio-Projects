/**
 * 
 *  src->
 *      Styles
 *      Dashboard components->
 *                Colors
 *                comp A
 *                comp B
 * 
 */



import React, { useState, useEffect } from "react";
import "./App.css";
import "bootstrap/dist/css/bootstrap.min.css";
import { Navbar, Container, Nav, Form, Button, Table } from "react-bootstrap";
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import EditIcon from "@material-ui/icons/Edit";
import UpdateIcon from "@material-ui/icons/Update";
import DeleteForeverIcon from "@material-ui/icons/DeleteForever";

export default class App extends React.Component {
  constructor(props) {
    super(props);
  }

  render() {
    return (
      <>
        <Router>
          <Switch>
            <Route exact path="/">
              <Menu></Menu>
              <Home></Home>
            </Route>

            <Route exact path="/Add">
              <Menu></Menu>
              <Add></Add>
            </Route>

            <Route exact path="/DisplayAll">
              <Menu></Menu>
              <DisplayAll></DisplayAll>
            </Route>
          </Switch>
        </Router>
      </>
    );
  }
}

function Menu() {
  return (
    <div className="App">
      <Navbar bg="dark" variant="dark">
        <Container>
          <Navbar.Brand>
            <Link to="/" class="link">
              To do List
            </Link>
          </Navbar.Brand>
          <Nav className="me-auto">
            <Nav.Link>
              <Link to="/DisplayAll" class="link">
                All Todos
              </Link>
            </Nav.Link>
            <Nav.Link>
              <Link to="/Add" class="link">
                Add New
              </Link>
            </Nav.Link>
          </Nav>
        </Container>
      </Navbar>
    </div>
  );
}

function Add() {
  const [desc, setDesc] = useState("");

  function handleInput(evt) {
    setDesc(evt.target.value);
  }

  function handleAdd() {
    fetch("http://localhost:5000/addItem", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ desc: desc }),
    }).then((resp) => {
      console.log(resp);
    });
  }

  return (
    <>
      <div className="container mt-2 p-4">
        <h1>Add a new to do</h1>
        <div className="mt-4">
          <Form>
            <Form.Group className="mb-3" controlId="formBasicPassword">
              <Form.Label>Task Description</Form.Label>
              <Form.Control
                type="text"
                placeholder="Task description"
                value={desc}
                onChange={handleInput}
              />
            </Form.Group>
            <Button variant="primary" onClick={handleAdd}>
              Add Task
            </Button>
          </Form>
        </div>
      </div>
    </>
  );
}

function Home() {
  return (
    <>
      <div className="container mt-2 p-4">
        <h1>Home</h1>
      </div>
    </>
  );
}

function DisplayAll() {
  const [items, setItems] = useState([
    {_id:"12", itemDescription:"Develop Web app for upwork client"},
    {_id:"15", itemDescription:"Teach ReactJS to John"},
    {_id:"17", itemDescription:"Learn NextJS"},
    {_id:"18", itemDescription:"Visit Restourant"},
    {_id:"13", itemDescription:"Chill, music, dance"},
    {_id:"11", itemDescription:"Update upwork profile"},
    {_id:"10", itemDescription:"Complete Job for dany"},
  ]);

  useEffect(() => {
    fetch("http://localhost:5000/getItems")
      .then((resp) => resp.json())
      .then((resp) => {
        console.log(resp);
        setItems(resp);
      });
  }, []);

  function handleEdit(id, evt) {
    document.getElementById(id).contentEditable = true;

    fetch("http://localhost:5000/update/" + id, {
      method: "PUT",
      headers: {
        "content-type": "application/json",
      },
      body: JSON.stringify({
        desc: items.filter((itm) => itm._id == id)[0].itemDescription,
      }),
    })
      .then((resp) => resp.text())
      .then((resp) => {
        console.log(resp);
      });
  }
  function handleDelete(id) {
    const rest = items.filter((item) => {
      //Make sure that content is not editable after deleting the current editable item, so
      document.getElementById(item._id).contentEditable = false;
      return item._id != id;
    });
    setItems(rest);
    
    fetch("http://localhost:5000/deleteItem/" + id, {
      method: "DELETE",
    })
      .then((resp) => resp.text())
      .then((resp) => {
        if (resp == 1) {
          const rest = items.filter((item) => {
            //Make sure that content is not editable after deleting the current editable item, so
            document.getElementById(item._id).contentEditable = false;
            return item._id != id;
          });
          setItems(rest);
        } else {
          alert("Error Occured! TRY AGAIN");
        }
      });
  }

  return (
    <>
      <div className="container mt-2 p-4">
        <h1>All To dos</h1>
        <div className="mt-4">
          <Table striped bordered hover>
            <thead>
              <tr>
                <th>Task Description</th>
                <th>Edit</th>
                <th>Delete</th>
              </tr>
            </thead>
            <tbody>
              {items.map((item) => {
                return (
                  <tr id={item._id}>
                    <td key={item._id}>{item.itemDescription}</td>
                    <td>
                      <EditIcon
                        style={{ cursor: "pointer", color: "blue" }}
                        onClick={(evt) => {
                          handleEdit(item._id, evt);
                        }}
                      ></EditIcon>
                    </td>

                    <td>
                      <DeleteForeverIcon
                        style={{ cursor: "pointer", color: "red" }}
                        onClick={() => {
                          handleDelete(item._id);
                        }}
                      ></DeleteForeverIcon>
                    </td>
                  </tr>
                );
              })}
            </tbody>
          </Table>
        </div>
      </div>
    </>
  );
}
