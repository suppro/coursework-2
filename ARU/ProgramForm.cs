using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARU
{
    public partial class ProgramForm : Form
    {
        string loginName;
        int loginedUserId;
        Client client = new Client();
        Grave grave = new Grave();
        Employee employee = new Employee();
        Deceased deceased = new Deceased();
        Order order = new Order();
        Order_Grave orderGrave = new Order_Grave();
        public ProgramForm(string loginName)
        {
            InitializeComponent();
            this.loginName = loginName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "partsOrderData1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter4.Fill(this.partsOrderData1.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orderData1.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter2.Fill(this.orderData1.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orderData1.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter2.Fill(this.orderData1.Order);
            LoadUserInfo();
            UpdateForm();
        }

        private void LoadUserInfo()
        {
            lbDate.Text = Convert.ToString(DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
            using (ARUDBEntities db = new ARUDBEntities())
            {

                Employee model = (from u in db.Employee
                                  join q in db.Position on u.position_id equals q.id
                                  where u.login == loginName
                                  select u).FirstOrDefault();
                lbEmployeeName.Text = model.name + " " + model.surname;
                lbPosition.Text = model.Position.position_name;
                loginedUserId = model.id;
                if (model.position_id != 1)
                    tabPage2.Parent = null;
                if (model == null)
                {
                    MessageBox.Show("Ошибка закрузки данных пользователя", "Ошибка");
                    return;
                }
            }
        }

        //Добавление 
        private void AddClient(object sender, EventArgs e)
        {
            client.surname = txtClientSurname.Text.Trim();
            client.name = txtClientName.Text.Trim();
            client.patronymic = txtClientPatronymic.Text.Trim();
            client.telephone_number = txtClientPhone.Text.Trim();
            if (String.IsNullOrEmpty(client.surname) || String.IsNullOrEmpty(client.name) || String.IsNullOrEmpty(client.patronymic) || String.IsNullOrEmpty(client.telephone_number))
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
            this.clientTableAdapter1.Fill(this.clientsData1.Client);
            MessageBox.Show("Данные успешно добавлены");
            ClearClient();
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
                    db.Employee.Add(employee);
                else
                    db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Данные успешно добавлены");
                ClearEmployee();
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
                MessageBox.Show("Данные успешно добавлены");
                ClearDeceased();
            }
        }

        private void AddOrder(object sender, EventArgs e)
        {
            order.employee_id = loginedUserId;
            order.client_id = Convert.ToInt32(txtClientID.Text.Trim());
            order.order_sum = Convert.ToInt32(txtOrderSum.Text.Trim());
            order.order_date = txtOrderData.Value.Date;
            
            order.parts_order = Convert.ToInt32(cbPartsOrder.GetItemText(cbPartsOrder.SelectedItem));
            order.added_parts = 0;

            using (ARUDBEntities db = new ARUDBEntities())
            {
                Order model = (from u in db.Order
                               orderby u.order_num descending
                               select u).FirstOrDefault();
                if (model != null)
                    order.order_num = model.order_num + 1;
                else
                    order.order_num = 544000;
            }

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
                txtClientID.Text = txtOrderSum.Text = txtOrderData.Text = cbPartsOrder.Text = "";
                deceased.id = 0;
                this.orderTableAdapter2.Fill(this.orderData1.Order);
                this.orderTableAdapter3.Fill(this.orderNumData1.Order);
                MessageBox.Show("Заказ успешно добавлен");
            }
        }
        private void AddPartOrder(object sender, EventArgs e)
        {
            int numberOrder = Convert.ToInt32(txtNumberOrder.Text);
            int numberGrave = Convert.ToInt32(txtNumGrave.Text.Trim());
            using (ARUDBEntities db = new ARUDBEntities())
            {
                order = db.Order.Where(x => x.order_num == numberOrder).FirstOrDefault();
                orderGrave.order_id = order.id;
            }
            
            orderGrave.deceased_id = Convert.ToInt32(txtIdDeceased.Text.Trim());
            orderGrave.burial_date = dtimeFuneral.Value.Date;
            bool add = true;

            if (String.IsNullOrEmpty(Convert.ToString(orderGrave.grave_id)) || String.IsNullOrEmpty(Convert.ToString(orderGrave.order_id)) || String.IsNullOrEmpty(Convert.ToString(orderGrave.status_id)) 
                || String.IsNullOrEmpty(Convert.ToString(orderGrave.deceased_id)) || String.IsNullOrEmpty(Convert.ToString(orderGrave.burial_date)))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }

            if (orderGrave.id == 0)
                if (!VerificationForm(numberGrave))
                    return;

            

            using (ARUDBEntities db = new ARUDBEntities())
            {
                if (orderGrave.id == 0)
                {
                    
                    orderGrave.status_id = 1;
                    db.Order_Grave.Add(orderGrave);
                    MessageBox.Show("Часть заказа " + numberOrder + " успешно добавлена");
                }
                else
                {
                    numberOrder = Convert.ToInt32(txtNumberOrder.Text.Trim());
                    orderGrave.status_id = Convert.ToInt32(cbStatusOrder.SelectedValue);
                    MessageBox.Show(orderGrave.status_id.ToString());
                    db.Entry(orderGrave).State = EntityState.Modified;
                    add = false;
                    
                }
                db.SaveChanges();
                ClearPartsOrder();
            }

            if (add)
            {
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    order = db.Order.Where(x => x.id == orderGrave.order_id).FirstOrDefault();
                    order.added_parts += 1;
                    db.Entry(order).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Кол-во частей заказа стало " + order.added_parts);
                }

                using (ARUDBEntities db = new ARUDBEntities())
                {
                    grave = db.Grave.Where(x => x.id == orderGrave.grave_id).FirstOrDefault();
                    grave.gravestatus_id = 2;
                    db.Entry(grave).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Cтатус могилы изменился");
                }
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    deceased = db.Deceased.Where(x => x.id == orderGrave.deceased_id).FirstOrDefault();
                    //deceased.id = orderGrave.deceased_id;
                    deceased.deceased_status_id = 2;
                    db.Entry(deceased).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Статус покойника изменился");
                }
                UpdateForm();
            }

            else
               UpdateForm();
        }
        private void SelectClient(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Index != -1)
            {
                btnClearClient.Enabled = true;
                client.id = Convert.ToInt32(dgvClient.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value);
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    client = db.Client.Where(x => x.id == client.id).FirstOrDefault();
                    txtClientName.Text = client.name;
                    txtClientSurname.Text = client.surname;
                    txtClientPatronymic.Text = client.patronymic;
                    txtClientPhone.Text = client.telephone_number;
                }
                btnClient.Text = "Обновить запись";
                btnDeleteClient.Enabled = true;
            }
        }
        //Обновление
        private void SelectPartOrder(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Index != -1)
            {
                btnClearPartOrder.Enabled = true;
                txtNumberOrder.Enabled = false;
                txtIdDeceased.Enabled = false;
                txtNumGrave.Enabled = false;
                cbStatusOrder.Enabled = true;
                dtimeFuneral.Enabled = false;
                orderGrave.id = Convert.ToInt32(dgvPartsOrder.CurrentRow.Cells["dataGridViewTextBoxColumn31"].Value);
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    orderGrave = db.Order_Grave.Where(x => x.id == orderGrave.id).FirstOrDefault();
                    order = db.Order.Where(x => x.id == orderGrave.order_id).FirstOrDefault();
                    grave = db.Grave.Where(x => x.id == orderGrave.grave_id).FirstOrDefault();
                    txtNumberOrder.Text = order.order_num.ToString();
                    txtIdDeceased.Text = orderGrave.deceased_id.ToString();
                    txtNumGrave.Text = grave.grave_number.ToString();
                    dtimeFuneral.Value = orderGrave.burial_date;
                }
                btnAddParts.Text = "Обновить запись";
                btnDeleteClient.Enabled = true;
            }
        }
        private void SelectEmployee(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow.Index != -1)
            {
                btnClearEmployee.Enabled = true;
                employee.id = Convert.ToInt32(dgvEmployee.CurrentRow.Cells["dataGridViewTextBoxColumn12"].Value);
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    employee = db.Employee.Where(x => x.id == employee.id).FirstOrDefault();
                    txtEmployeeName.Text = employee.name;
                    txtEmployeePatronymic.Text = employee.surname;
                    txtEmployeeSurname.Text = employee.patronymic;
                    txtEmployeeAge.Text = employee.age.ToString();
                    cmbEmployeePosition.SelectedIndex = employee.position_id;
                }
                btnEmployee.Text = "Обновить запись";
                btnDeleteEmployee.Enabled = true;
            }
        }
        private void SelectDeceased(object sender, EventArgs e)
        {
            if (dgvDeceased.CurrentRow.Index != -1)
            {
                btnClearDeceased.Enabled = true;
                deceased.id = Convert.ToInt32(dgvDeceased.CurrentRow.Cells["dataGridViewTextBoxColumn5"].Value);
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    deceased = db.Deceased.Where(x => x.id == client.id).FirstOrDefault();
                    txtDeceasedName.Text = deceased.name;
                    txtDeceasedPatronymic.Text = deceased.patronymic;
                    txtDeceasedSurname.Text = deceased.surname;
                    dtimeBirth.Value = deceased.birth_date;
                    dtimeDead.Value = deceased.death_date;
                }
                btnDeceased.Text = "Обновить запись";
                btnDeleteDeceased.Enabled = true;
            }
        }

        private void SelectOrder(object sender, EventArgs e)
        {
            if (dgvDeceased.CurrentRow.Index != -1)
            {
                int numberOrder;
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    
                    order = db.Order.Where(x => x.id == order.id).FirstOrDefault();
                    numberOrder = order.order_num;
                }
                btnAddOrder.Enabled = false;
                btnDeceased.Text = "Обновить запись";
            }
        }

        private void CancelSelection(object sender, EventArgs e)
        {
            dgvOrder.ClearSelection();
            dgvClient.ClearSelection();
            dgvDeceased.ClearSelection();
            dgvPartsOrder.ClearSelection();
            dgvEmployee.ClearSelection();
        }

        private void UpdateForm()
        {
            this.dataTable1TableAdapter4.Fill(this.partsOrderData1.DataTable1);
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



        private void DeleteClient(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    client.deleted = 1;
                    db.Entry(client).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            ClearClient();
            btnDeleteClient.Enabled = false;
            MessageBox.Show("Удаление прошло успешно");
        }

        private void DeleteEmployee(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    employee.deleted = 1;
                    db.Entry(employee).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            ClearEmployee();
            btnDeleteDeceased.Enabled = false;
            MessageBox.Show("Удаление прошло успешно");
        }

        private void DeleteDeceased(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ARUDBEntities db = new ARUDBEntities())
                {
                    deceased.deleted = 1;
                    db.Entry(deceased).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            ClearDeceased();
            btnDeleteDeceased.Enabled = false;
            MessageBox.Show("Удаление прошло успешно");
        }

        private void ClearClientClick(object sender, EventArgs e)
        {
            ClearClient();
        }

        private void ClearEmployeeClick(object sender, EventArgs e)
        {
            ClearEmployee();
        }

        private void ClearDeceasedClick(object sender, EventArgs e)
        {
            ClearDeceased();
        }

        private void ClearPartsOrderClick(object sender, EventArgs e)
        {
            ClearPartsOrder();
        }

        private void ClearClient()
        {
            this.clientTableAdapter1.Fill(this.clientsData1.Client);
            txtClientName.Text = txtClientSurname.Text = txtClientPatronymic.Text = txtClientPhone.Text = "";
            btnClient.Text = "Добавить запись";
            btnClearClient.Enabled = false;
            btnDeleteClient.Enabled = false;
            client.id = 0;
        }
        private void ClearEmployee()
        {
            this.dataTable1TableAdapter3.Fill(this.employeeData1.DataTable1);
            txtEmployeeName.Text = txtEmployeeSurname.Text = txtEmployeePatronymic.Text = txtEmployeeAge.Text = cmbEmployeePosition.Text = "";
            btnEmployee.Text = "Добавить запись";
            btnClearClient.Enabled = false;
            btnDeleteEmployee.Enabled = false;
            employee.id = 0;
        }
        private void ClearDeceased()
        {
            this.deceasedTableAdapter1.Fill(this.deceasedData1.Deceased);
            txtDeceasedName.Text = txtDeceasedSurname.Text = txtDeceasedPatronymic.Text = dtimeBirth.Text = dtimeDead.Text = "";
            btnDeceased.Text = "Добавить запись";
            btnClearClient.Enabled = false;
            btnDeleteDeceased.Enabled = false;
            deceased.id = 0;
        }
        private void ClearPartsOrder()
        {
            this.dataTable1TableAdapter4.Fill(this.partsOrderData1.DataTable1);
            txtIdDeceased.Text = txtNumGrave.Text = cbStatusOrder.Text = dtimeBirth.Text = dtimeFuneral.Text = "";
            btnAddParts.Text = "Добавить запись";
            btnDeleteDeceased.Enabled = false;
            btnClearPartOrder.Enabled = false;
            txtNumberOrder.Enabled = true;
            txtIdDeceased.Enabled = true;
            txtNumGrave.Enabled = true;
            dtimeFuneral.Enabled = true;
            cbStatusOrder.Enabled = true;
        }

        private bool VerificationForm(int numberGrave)
        {
            using (ARUDBEntities db = new ARUDBEntities())
            {
                Grave model = (from u in db.Grave
                               where u.grave_number == numberGrave
                               select u).FirstOrDefault();
                orderGrave.grave_id = model.id;
                if (model.gravestatus_id == 2)
                {
                    MessageBox.Show("Данное место захоронения уже занято"); return false;
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
                    MessageBox.Show("Дата захоронения должна быть больше, чем дата заказа"); return false;
                }
            }

            using (ARUDBEntities db = new ARUDBEntities())
            {
                Deceased model = (from u in db.Deceased
                                  where u.id == orderGrave.deceased_id
                                  select u).FirstOrDefault();

                if (model.deceased_status_id == 2)
                {
                    MessageBox.Show("Выбранный покойник уже похоронен"); return false;
                }
            }
            return true;
        }
        private void СloseApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
