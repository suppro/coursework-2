using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARU
{
    public partial class Form1 : Form
    {
        Client client = new Client();
        Grave grave = new Grave();
        Employee employee = new Employee();
        Deceased deceased = new Deceased();
        Order order = new Order();
        Order_Grave orderGrave = new Order_Grave();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orderData1.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter2.Fill(this.orderData1.Order);
            this.dataTable1TableAdapter5.Fill(this.graveData1.DataTable1);
            this.positionTableAdapter1.Fill(this.positionsData1.Position);
            this.statusTableAdapter1.Fill(this.statusData1.Status);
            this.orderTableAdapter3.Fill(this.orderNumData1.Order);
            this.dataTable1TableAdapter4.Fill(this.partsOrderData1.DataTable1);
            this.orderTableAdapter2.Fill(this.orderData1.Order);
            this.dataTable1TableAdapter3.Fill(this.employeeData1.DataTable1);
            this.deceasedTableAdapter1.Fill(this.deceasedData1.Deceased);
            this.clientTableAdapter1.Fill(this.clientsData1.Client);
        }

        //Добавление 
        private void AddClient(object sender, EventArgs e)
        {
            client.surname = txtClientSurname.Text.Trim();
            client.name = txtClientName.Text.Trim();
            client.patronymic = txtClientPatronymic.Text.Trim();
            if (String.IsNullOrEmpty(client.surname) || String.IsNullOrEmpty(client.name) || String.IsNullOrEmpty(client.patronymic))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }

            using (ARUDBEntities db = new ARUDBEntities())
            {
                if (client.id == 0)
                    db.Client.Add(client);
                else
                    db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
            }
            txtClientName.Text = txtClientSurname.Text = txtClientPatronymic.Text = "";
            client.id = 0;
            btnDeleteClient.Enabled = true;
            this.clientTableAdapter1.Fill(this.clientsData1.Client);
            MessageBox.Show("Данные успешно добавлены");
        }
        private void AddGrave(object sender, EventArgs e)
        {
            grave.grave_number = dataGridView1.Rows.Count + 1;
            grave.gravestatus_id = 1;
            using (ARUDBEntities db = new ARUDBEntities())
            {
                if (grave.id == 0)
                    db.Grave.Add(grave);
                else
                    db.Entry(grave).State = EntityState.Modified;
                db.SaveChanges();
                client.id = 0;
                this.dataTable1TableAdapter5.Fill(this.graveData1.DataTable1);
                MessageBox.Show("Могила успешно добавлена");
            }
        }
        private void AddPersonal(object sender, EventArgs e)
        {
            employee.name = txtEmployeeName.Text.Trim();
            employee.surname = txtEmployeeSurname.Text.Trim();
            employee.patronymic = txtEmployeePatronymic.Text.Trim();
            employee.position_id = cmbEmployeePosition.SelectedIndex;
            employee.age = Convert.ToInt32(txtEmployeeAge.Text.Trim());
            if (String.IsNullOrEmpty(employee.name) || String.IsNullOrEmpty(employee.surname) || String.IsNullOrEmpty(employee.patronymic) || String.IsNullOrEmpty(employee.position_id.ToString())
                || String.IsNullOrEmpty(employee.age.ToString()))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }
            using (ARUDBEntities db = new ARUDBEntities())
            {
                if (client.id == 0)
                    db.Client.Add(client);
                else
                    db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                txtEmployeeName.Text = txtEmployeeSurname.Text = txtEmployeePatronymic.Text = txtEmployeeAge.Text = cmbEmployeePosition.Text =  "";
                client.id = 0;
                this.dataTable1TableAdapter3.Fill(this.employeeData1.DataTable1);
                MessageBox.Show("Сотрудник успешно добавлен");
            }
        }
        private void AddDeceased(object sender, EventArgs e)
        {
            deceased.name = txtDeceasedName.Text.Trim();
            deceased.surname = txtDeceasedSurname.Text.Trim();
            deceased.patronymic = txtDeceasedPatronymic.Text.Trim();
            deceased.birth_date = dtimeBirth.Value.Date;
            deceased.death_date = dtimeDead.Value.Date;
            deceased.deceased_status_id = 1;
            if (String.IsNullOrEmpty(deceased.name) || String.IsNullOrEmpty(deceased.surname) || String.IsNullOrEmpty(deceased.name) || String.IsNullOrEmpty(Convert.ToString(deceased.birth_date))
                || String.IsNullOrEmpty(Convert.ToString(deceased.death_date)))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }
            using (ARUDBEntities db = new ARUDBEntities())
            {
                if (deceased.id == 0)
                    db.Deceased.Add(deceased);
                else
                    db.Entry(deceased).State = EntityState.Modified;
                db.SaveChanges();
                txtDeceasedName.Text = txtDeceasedSurname.Text = txtDeceasedPatronymic.Text = dtimeBirth.Text = dtimeDead.Text = "";
                deceased.id = 0;
                this.deceasedTableAdapter1.Fill(this.deceasedData1.Deceased);
                MessageBox.Show("Покойник успешно добавлен");
            }
        }

        private void AddOrder(object sender, EventArgs e)
        {
            order.employee_id = Convert.ToInt32(txtEmployeeID.Text.Trim());
            order.client_id = Convert.ToInt32(txtClientID.Text.Trim());
            order.order_sum = Convert.ToInt32(txtOrderSum.Text.Trim());
            order.order_date = txtOrderData.Value.Date;
            order.order_num = Convert.ToInt32(dgvOrder[0, dgvOrder.Rows.Count - 1].Value) + 1;
            order.parts_order = Convert.ToInt32(cbPartsOrder.GetItemText(cbPartsOrder.SelectedItem));


            if (String.IsNullOrEmpty(order.employee_id.ToString()) || String.IsNullOrEmpty(order.client_id.ToString()) || String.IsNullOrEmpty(order.order_sum.ToString()) || String.IsNullOrEmpty(order.order_date.Date.ToString())
                || String.IsNullOrEmpty(order.parts_order.ToString())  || String.IsNullOrEmpty(Convert.ToString(deceased.death_date)))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }

            DateTime dateOrder = new DateTime(txtOrderData.Value.Year, txtOrderData.Value.Month, txtOrderData.Value.Day);
            MessageBox.Show(Convert.ToString(dateOrder) + " " + Convert.ToString(DateTime.Today));

            if (dateOrder > DateTime.Today)
            {
                MessageBox.Show("Дата заказа должна совпадать с текущей датой или быть прошедшей"); return;
            }

            using (ARUDBEntities db = new ARUDBEntities())
            {
                if (order.id == 0)
                    db.Order.Add(order);
                else
                    db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                txtEmployeeID.Text = txtClientID.Text = txtOrderSum.Text = txtOrderData.Text = cbPartsOrder.Text = "";
                deceased.id = 0;
                this.orderTableAdapter2.Fill(this.orderData1.Order);
                MessageBox.Show("Заказ успешно добавлен");
            }
        }
        private void AddPartOrder(object sender, EventArgs e)
        {
            int numberOrder = Convert.ToInt32(cbOrderNum.GetItemText(cbOrderNum.SelectedItem));
            int numberGrave = Convert.ToInt32(txtNumGrave.Text.Trim());
            orderGrave.order_id = Convert.ToInt32(cbOrderNum.SelectedValue.ToString());
            orderGrave.status_id = cbStatusOrder.SelectedIndex + 1;
            orderGrave.deceased_id = Convert.ToInt32(txtIdDeceased.Text.Trim());
            orderGrave.burial_date = dtimeFuneral.Value.Date;

            if (String.IsNullOrEmpty(Convert.ToString(orderGrave.grave_id)) || String.IsNullOrEmpty(Convert.ToString(orderGrave.order_id)) || String.IsNullOrEmpty(Convert.ToString(orderGrave.status_id)) 
                || String.IsNullOrEmpty(Convert.ToString(orderGrave.deceased_id)) || String.IsNullOrEmpty(Convert.ToString(orderGrave.burial_date)))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }

            using (ARUDBEntities db = new ARUDBEntities())
            {
                Grave model = (from u in db.Grave
                               where u.grave_number == numberGrave
                               select u).FirstOrDefault();
                orderGrave.grave_id = model.id;
                if (model.gravestatus_id == 2)
                {
                    MessageBox.Show("Данное место захоронения уже занято"); return;
                }
            }

            DateTime dateBurial = new DateTime(dtimeFuneral.Value.Year, dtimeFuneral.Value.Month, dtimeFuneral.Value.Day);
            using (ARUDBEntities db = new ARUDBEntities())
            {
                Order model = (from u in db.Order
                               where u.id == orderGrave.order_id
                               select u).FirstOrDefault();
                DateTime dateOrder = new DateTime(model.order_date.Year, model.order_date.Month, model.order_date.Day);
                if (dateBurial <= dateOrder)
                {
                    MessageBox.Show("Дата захоронения должна быть больше, чем дата заказа"); return;
                }
            }

            using (ARUDBEntities db = new ARUDBEntities())
            {
                Deceased model = (from u in db.Deceased
                                  where u.id == orderGrave.deceased_id
                                  select u).FirstOrDefault();

                if (model.deceased_status_id == 2)
                {
                    MessageBox.Show("Выбранный покойник уже похоронен"); return;
                }
            }

            using (ARUDBEntities db = new ARUDBEntities())
            {
                if (orderGrave.id == 0)
                    db.Order_Grave.Add(orderGrave);
                else
                    db.Entry(orderGrave).State = EntityState.Modified;
                db.SaveChanges();
                txtNumGrave.Text = cbPartsOrder.Text = txtIdDeceased.Text = dtimeFuneral.Text = cbStatusOrder.Text = "";
                orderGrave.id = 0;
                this.dataTable1TableAdapter4.Fill(this.partsOrderData1.DataTable1);
                MessageBox.Show("Часть заказа " + numberOrder  + " успешно добавлена");
            }

            using (ARUDBEntities db = new ARUDBEntities())
            {
                grave.id = orderGrave.grave_id;
                grave.grave_number = numberGrave;
                grave.gravestatus_id = 2;
                deceased.id = orderGrave.deceased_id;
                deceased.deceased_status_id = 2;
                db.Entry(grave).State = EntityState.Modified;
                db.Entry(deceased).State = EntityState.Modified;
                db.SaveChanges();
                this.dataTable1TableAdapter5.Fill(this.graveData1.DataTable1);
                this.dataTable1TableAdapter5.Fill(this.graveData1.DataTable1);
            }
        }
        //Обновление
        private void selectClient(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Index != -1)
            {
                client.id = Convert.ToInt32(dgvClient.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    client = db.Client.Where(x => x.id == client.id).FirstOrDefault();
                    txtClientName.Text = client.name;
                    txtClientSurname.Text = client.surname;
                    txtClientPatronymic.Text = client.patronymic;
                }
                btnClient.Text = "Обновить запись";
                btnDeleteClient.Enabled = false;
            }
        }
        /*
        private void selectPersonal(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Index != -1)
            {
                client.id = Convert.ToInt32(dgvClient.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    client = db.Client.Where(x => x.id == client.id).FirstOrDefault();
                    txtClientName.Text = client.name;
                    txtClientSurname.Text = client.surname;
                    txtClientPatronymic.Text = client.patronymic;
                }
                btnClient.Text = "Обновить запись";
                btnDeleteClient.Enabled = false;
            }
        }
        private void selectDeceased(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Index != -1)
            {
                client.id = Convert.ToInt32(dgvClient.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    client = db.Client.Where(x => x.id == client.id).FirstOrDefault();
                    txtClientName.Text = client.name;
                    txtClientSurname.Text = client.surname;
                    txtClientPatronymic.Text = client.patronymic;
                }
                btnClient.Text = "Обновить запись";
                btnDeleteClient.Enabled = false;
            }
        }
        private void selectOrder(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Index != -1)
            {
                client.id = Convert.ToInt32(dgvClient.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    client = db.Client.Where(x => x.id == client.id).FirstOrDefault();
                    txtClientName.Text = client.name;
                    txtClientSurname.Text = client.surname;
                    txtClientPatronymic.Text = client.patronymic;
                }
                btnClient.Text = "Обновить запись";
                btnDeleteClient.Enabled = false;
            }
        }
        private void selectPartsOrder(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Index != -1)
            {
                client.id = Convert.ToInt32(dgvClient.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    client = db.Client.Where(x => x.id == client.id).FirstOrDefault();
                    txtClientName.Text = client.name;
                    txtClientSurname.Text = client.surname;
                    txtClientPatronymic.Text = client.patronymic;
                }
                btnClient.Text = "Обновить запись";
                btnDeleteClient.Enabled = false;
            }
        }
        */
    }
}
